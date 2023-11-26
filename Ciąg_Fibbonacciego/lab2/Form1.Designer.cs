namespace lab2
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
            this.wciskaj = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ln)).BeginInit();
            this.SuspendLayout();
            // 
            // wciskaj
            // 
            this.wciskaj.Location = new System.Drawing.Point(360, 258);
            this.wciskaj.Name = "wciskaj";
            this.wciskaj.Size = new System.Drawing.Size(75, 23);
            this.wciskaj.TabIndex = 0;
            this.wciskaj.Text = "wciskaj";
            this.wciskaj.UseVisualStyleBackColor = true;
            this.wciskaj.Click += new System.EventHandler(this.wciskaj_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(289, 134);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(120, 23);
            this.ln.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.wciskaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button wciskaj;
        private NumericUpDown ln;
    }
}