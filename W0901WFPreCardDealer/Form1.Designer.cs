namespace W0901WFPreCardDealer
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
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(12, 12);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(270, 426);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(12, 453);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(270, 57);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "카드 분배";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.OnDeal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 522);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.Card1);
            this.Name = "Form1";
            this.Text = "카드 딜러";
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Card1;
        private Button btnDeal;
    }
}