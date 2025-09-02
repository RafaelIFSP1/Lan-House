namespace LanHouseSystem
{
    partial class PC1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnexitpc1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitpc1
            // 
            this.btnexitpc1.BackColor = System.Drawing.Color.Red;
            this.btnexitpc1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitpc1.Location = new System.Drawing.Point(668, 12);
            this.btnexitpc1.Name = "btnexitpc1";
            this.btnexitpc1.Size = new System.Drawing.Size(120, 35);
            this.btnexitpc1.TabIndex = 0;
            this.btnexitpc1.Text = "SAIR";
            this.btnexitpc1.UseVisualStyleBackColor = false;
            this.btnexitpc1.Click += new System.EventHandler(this.btnexitpc1_Click);
            // 
            // PC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexitpc1);
            this.Name = "PC1";
            this.Text = "FormCronometroPC1";
            this.Load += new System.EventHandler(this.FormCronometroPC1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnexitpc1;
    }
}