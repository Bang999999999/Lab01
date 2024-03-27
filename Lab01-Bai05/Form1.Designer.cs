namespace MathOperationsApp
{
    partial class MainForm
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
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(12, 12);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(100, 20);
            this.txtNumberA.TabIndex = 0;
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(132, 12);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(100, 20);
            this.txtNumberB.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(262, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Tính toán";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 50);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(325, 190);
            this.richTextBoxResult.TabIndex = 3;
            this.richTextBoxResult.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 252);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Name = "MainForm";
            this.Text = "Math Operations";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumberA;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}
