using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VICEDO_IT201WM_LABACT3CDBS_MIDTERM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            EvaluateButtonClicked();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void EvaluateButtonClicked()
        {
            if (IsEmpty(txtBudget.Text) || IsEmpty(txtCost.Text) || IsEmpty(txtImportance.Text) || cbUrgency.SelectedIndex < 0 || cbRisk.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!IsNumeric(txtBudget.Text) || !IsNumeric(txtCost.Text) || !IsNumeric(txtImportance.Text))
            {
                MessageBox.Show("Budget, Estimated Cost and Importance must be numeric.");
                return;
            }

            double budget = ToDouble(txtBudget.Text);
            double cost = ToDouble(txtCost.Text);
            int importance = ToInt(txtImportance.Text);
            string urgency = cbUrgency.SelectedItem.ToString();
            string risk = cbRisk.SelectedItem.ToString();

            string affordability = CheckAffordability(budget, cost);
            int priority = ComputePriority(importance, urgency);
            string riskEval = EvaluateRisk(risk);
            string decision = GenerateDecision(affordability, priority, riskEval);
            string explanation = GenerateExplanation(affordability, priority, riskEval, decision);

            DisplayResult(affordability, priority, riskEval, decision, explanation);
        }

        private void ResetAll()
        {
            txtBudget.Text = "";
            txtCost.Text = "";
            txtImportance.Text = "";
            cbUrgency.SelectedIndex = -1;
            cbRisk.SelectedIndex = -1;
            lblAffordability.Text = "Affordability:";
            lblPriority.Text = "Priority Score:";
            lblRiskResult.Text = "Risk Level:";
            lblDecision.Text = "Decision:";
            lblExplanation.Text = "Explanation:";
        }

        private bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        private bool IsNumeric(string input)
        {
            double tmp;
            return double.TryParse(input, out tmp);
        }

        private double ToDouble(string input)
        {
            double.TryParse(input, out double v);
            return v;
        }

        private int ToInt(string input)
        {
            int.TryParse(input, out int v);
            return v;
        }

        private string CheckAffordability(double budget, double cost)
        {
            if (budget <= 0 || cost <= 0)
                return "Critical";
            if (budget >= cost)
                return "Affordable";
            if (budget >= cost * 0.7)
                return "Not Affordable";
            return "Critical";
        }

        private int ComputePriority(int importance, string urgency)
        {
            int urgencyWeight = UrgencyToWeight(urgency);
            int clampedImportance = Math.Max(1, Math.Min(10, importance));
            return clampedImportance * urgencyWeight;
        }

        private int UrgencyToWeight(string urgency)
        {
            switch (urgency)
            {
                case "Low": return 1;
                case "Medium": return 2;
                case "High": return 3;
                default: return 1;
            }
        }

        private string EvaluateRisk(string riskLevel)
        {
            switch (riskLevel)
            {
                case "Low": return "Safe";
                case "Medium": return "Moderate";
                case "High": return "High Risk";
                default: return "Moderate";
            }
        }

        private string GenerateDecision(string affordability, int priorityScore, string riskEval)
        {
            if (affordability == "Affordable" && riskEval == "Safe")
            {
                if (priorityScore >= 20) return "Proceed Immediately";
                return "Proceed with Caution";
            }

            if (affordability == "Not Affordable")
            {
                if (priorityScore >= 25 && riskEval != "High Risk") return "Proceed with Caution";
                return "Delay Decision";
            }

            if (affordability == "Critical")
            {
                return "Not Recommended";
            }

            if (riskEval == "High Risk")
            {
                if (priorityScore >= 25 && affordability == "Affordable") return "Proceed with Caution";
                return "Not Recommended";
            }

            return "Delay Decision";
        }

        private string GenerateExplanation(string affordability, int priorityScore, string riskEval, string decision)
        {
            if (decision == "Proceed Immediately")
                return "Affordable, low risk and high priority. You can go ahead now.";
            if (decision == "Proceed with Caution")
                return "Some concerns detected — consider reviewing budget or mitigating risks before proceeding.";
            if (decision == "Delay Decision")
                return "Current conditions are not ideal. Reassess priority, increase budget or reduce cost.";
            return "Not recommended due to critical financial or risk concerns.";
        }

        private void DisplayResult(string affordability, int priorityScore, string riskEval, string decision, string explanation)
        {
            lblAffordability.Text = "Affordability: " + affordability;
            lblPriority.Text = "Priority Score: " + priorityScore.ToString();
            lblRiskResult.Text = "Risk Level: " + riskEval;
            lblDecision.Text = "Decision: " + decision;
            lblExplanation.Text = "Explanation: " + explanation;
        }
    }
}
