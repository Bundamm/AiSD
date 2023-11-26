namespace DrzewoBinarne
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
            start = new Button();
            tbInput = new TextBox();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(346, 308);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 0;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // tbInput
            // 
            tbInput.Location = new Point(332, 218);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(100, 23);
            tbInput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInput);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private TextBox tbInput;
    }
}