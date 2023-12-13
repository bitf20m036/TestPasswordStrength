using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestPasswordStrength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            PasswordStrengthResult result = CheckPasswordStrength(password);

            // Display detailed feedback
            lblResult.Text = result.Strength;
            lblFeedback.Text = result.Feedback;

            // Update progress bar
            progressBar.Value = result.Score;
        }

        private PasswordStrengthResult CheckPasswordStrength(string password)
        {
            // Add your criteria for password strength
            bool lengthCriteria = password.Length >= 8;
            bool uppercaseCriteria = password.Any(char.IsUpper);
            bool lowercaseCriteria = password.Any(char.IsLower);
            bool digitCriteria = password.Any(char.IsDigit);
            bool specialCharCriteria = password.Any(c => !char.IsLetterOrDigit(c));

            // Calculate the password score
            int score = CalculatePasswordScore(lengthCriteria, uppercaseCriteria, lowercaseCriteria, digitCriteria, specialCharCriteria);

            // Provide feedback based on the score
            string feedback = GetPasswordFeedback(score);

            // Determine the overall strength
            string strength;
            if (score >= 80)
                strength = "Strong password";
            else if (score >= 50)
                strength = "Moderate password";
            else
                strength = "Weak password";

            return new PasswordStrengthResult(strength, feedback, score);
        }

        private int CalculatePasswordScore(bool length, bool uppercase, bool lowercase, bool digit, bool specialChar)
        {
            int score = 0;

            // Add scores based on criteria
            score += length ? 20 : 0;
            score += uppercase ? 20 : 0;
            score += lowercase ? 20 : 0;
            score += digit ? 20 : 0;
            score += specialChar ? 20 : 0;

            return score;
        }

        private string GetPasswordFeedback(int score)
        {
            // Provide feedback based on the score
            if (score >= 80)
                return "Excellent! Your password is very strong.";
            else if (score >= 50)
                return "Good effort! Your password is moderate. Consider adding more complexity.";
            else
                return "Weak password. Please choose a stronger password.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }

    public class PasswordStrengthResult
    {
        public string Strength { get; }
        public string Feedback { get; }
        public int Score { get; }

        public PasswordStrengthResult(string strength, string feedback, int score)
        {
            Strength = strength;
            Feedback = feedback;
            Score = score;
        }
    }
}
