namespace cw3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbB = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(345, 219);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(75, 23);
            this.tbB.TabIndex = 0;
            this.tbB.Text = "start";
            this.tbB.UseVisualStyleBackColor = true;
            this.tbB.Click += new System.EventHandler(this.start_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(335, 119);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 23);
            this.tbInput.TabIndex = 1;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(366, 170);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(38, 15);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tbB;
        private TextBox tbInput;
        private Label lblWynik;
    }
}