namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(141, 144);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "LOGIN";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(138, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(27, 25);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "...";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(143, 174);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 241);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnPosalji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnLogout;
    }
}

