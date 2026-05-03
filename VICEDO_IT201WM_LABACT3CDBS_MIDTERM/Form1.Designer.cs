namespace VICEDO_IT201WM_LABACT3CDBS_MIDTERM
{
    public partial class AppShell
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpenA = new System.Windows.Forms.ToolStripButton();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cbUrgency = new System.Windows.Forms.ComboBox();
            this.txtImportance = new System.Windows.Forms.TextBox();
            this.cbRisk = new System.Windows.Forms.ComboBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAffordability = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblRiskResult = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Text = "Decision Dashboard";
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsbOpenA });
            this.tsbOpenA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenA.Name = "tsbOpenA";
            this.tsbOpenA.Size = new System.Drawing.Size(60, 22);
            this.tsbOpenA.Text = "Open A";
            this.tsbOpenA.Click += new System.EventHandler(this.OpenChildFormA);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.Text = "Funds Available:";
            this.txtBudget.Location = new System.Drawing.Point(140, 27);
            this.txtBudget.Size = new System.Drawing.Size(180, 20);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.Text = "Projected Expense:";
            this.txtCost.Location = new System.Drawing.Point(140, 62);
            this.txtCost.Size = new System.Drawing.Size(180, 20);
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.Text = "Time Sensitivity:";
            this.cbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrgency.Items.AddRange(new object[] {"Low", "Medium", "High"});
            this.cbUrgency.Location = new System.Drawing.Point(140, 97);
            this.cbUrgency.Size = new System.Drawing.Size(180, 21);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.Text = "Priority (1-10):";
            this.txtImportance.Location = new System.Drawing.Point(140, 132);
            this.txtImportance.Size = new System.Drawing.Size(180, 20);
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.Text = "Exposure:";
            this.cbRisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRisk.Items.AddRange(new object[] {"Low", "Medium", "High"});
            this.cbRisk.Location = new System.Drawing.Point(140, 167);
            this.cbRisk.Size = new System.Drawing.Size(180, 21);
            this.btnEvaluate.Location = new System.Drawing.Point(35, 210);
            this.btnEvaluate.Size = new System.Drawing.Size(140, 30);
            this.btnEvaluate.Text = "Assess";
            this.btnEvaluate.Click += new System.EventHandler(this.HandleActionEvaluate);
            this.btnReset.Location = new System.Drawing.Point(180, 210);
            this.btnReset.Size = new System.Drawing.Size(140, 30);
            this.btnReset.Text = "Clear";
            this.btnReset.Click += new System.EventHandler(this.HandleActionClear);
            this.lblAffordability.Location = new System.Drawing.Point(360, 30);
            this.lblAffordability.Size = new System.Drawing.Size(380, 20);
            this.lblAffordability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAffordability.Text = "Affordability:";
            this.lblPriority.Location = new System.Drawing.Point(360, 65);
            this.lblPriority.Size = new System.Drawing.Size(380, 20);
            this.lblPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPriority.Text = "Priority Score:";
            this.lblRiskResult.Location = new System.Drawing.Point(360, 100);
            this.lblRiskResult.Size = new System.Drawing.Size(380, 20);
            this.lblRiskResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRiskResult.Text = "Risk Assessment:";
            this.lblDecision.Location = new System.Drawing.Point(360, 135);
            this.lblDecision.Size = new System.Drawing.Size(380, 20);
            this.lblDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecision.Text = "Recommendation:";
            this.lblExplanation.Location = new System.Drawing.Point(360, 170);
            this.lblExplanation.Size = new System.Drawing.Size(380, 140);
            this.lblExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExplanation.Text = "Details:";
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblAffordability);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblRiskResult);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUrgency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImportance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRisk);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnReset);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cbUrgency;
        private System.Windows.Forms.TextBox txtImportance;
        private System.Windows.Forms.ComboBox cbRisk;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAffordability;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblRiskResult;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpenA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        
    }
}

