namespace bubbleSort
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
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(370, 269);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.btnBubbleSort.TabIndex = 0;
            this.btnBubbleSort.Text = "start";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(294, 148);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(229, 23);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(390, 188);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(38, 15);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "label1";
            this.lblWynik.Click += new System.EventHandler(this.lblWynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnBubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBubbleSort;
        private TextBox tbInput;
        private Label lblWynik;
    }
}