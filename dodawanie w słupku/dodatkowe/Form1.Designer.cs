namespace dodatkowe
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
            a = new NumericUpDown();
            b = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)b).BeginInit();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(325, 277);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 0;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // a
            // 
            a.Location = new Point(25, 87);
            a.Name = "a";
            a.Size = new Size(120, 23);
            a.TabIndex = 1;
            a.ValueChanged += a_ValueChanged;
            // 
            // b
            // 
            b.Location = new Point(25, 149);
            b.Name = "b";
            b.Size = new Size(120, 23);
            b.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)a).EndInit();
            ((System.ComponentModel.ISupportInitialize)b).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private NumericUpDown a;
        private NumericUpDown b;
    }
}