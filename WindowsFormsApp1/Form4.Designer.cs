namespace LanHouseSystem
{
    partial class Form4
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
            this.btnPC1 = new System.Windows.Forms.Button();
            this.btnPC2 = new System.Windows.Forms.Button();
            this.btnPC3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPC1
            // 
            this.btnPC1.Location = new System.Drawing.Point(12, 31);
            this.btnPC1.Name = "btnPC1";
            this.btnPC1.Size = new System.Drawing.Size(80, 50);
            this.btnPC1.TabIndex = 0;
            this.btnPC1.Text = "PC - 01";
            this.btnPC1.UseVisualStyleBackColor = true;
            this.btnPC1.Click += new System.EventHandler(this.btnPC1_Click);
            // 
            // btnPC2
            // 
            this.btnPC2.Location = new System.Drawing.Point(118, 31);
            this.btnPC2.Name = "btnPC2";
            this.btnPC2.Size = new System.Drawing.Size(80, 50);
            this.btnPC2.TabIndex = 1;
            this.btnPC2.Text = "PC - 02";
            this.btnPC2.UseVisualStyleBackColor = true;
            this.btnPC2.Click += new System.EventHandler(this.btnPC2_Click);
            // 
            // btnPC3
            // 
            this.btnPC3.Location = new System.Drawing.Point(227, 31);
            this.btnPC3.Name = "btnPC3";
            this.btnPC3.Size = new System.Drawing.Size(80, 50);
            this.btnPC3.TabIndex = 2;
            this.btnPC3.Text = "PC - 03";
            this.btnPC3.UseVisualStyleBackColor = true;
            this.btnPC3.Click += new System.EventHandler(this.btnPC3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(723, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "SAIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(588, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "RECORDES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPC3);
            this.Controls.Add(this.btnPC2);
            this.Controls.Add(this.btnPC1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPC1;
        private System.Windows.Forms.Button btnPC2;
        private System.Windows.Forms.Button btnPC3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}