namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Btnexit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btntelapc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnexit2
            // 
            this.Btnexit2.BackColor = System.Drawing.Color.Red;
            this.Btnexit2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexit2.Location = new System.Drawing.Point(662, 12);
            this.Btnexit2.Name = "Btnexit2";
            this.Btnexit2.Size = new System.Drawing.Size(120, 35);
            this.Btnexit2.TabIndex = 0;
            this.Btnexit2.Text = "SAIR";
            this.Btnexit2.UseVisualStyleBackColor = false;
            this.Btnexit2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(662, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntelapc
            // 
            this.btntelapc.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntelapc.Location = new System.Drawing.Point(20, 166);
            this.btntelapc.Name = "btntelapc";
            this.btntelapc.Size = new System.Drawing.Size(89, 69);
            this.btntelapc.TabIndex = 2;
            this.btntelapc.Text = "RECURSOS";
            this.btntelapc.UseVisualStyleBackColor = true;
            this.btntelapc.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 447);
            this.Controls.Add(this.btntelapc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btnexit2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnexit2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntelapc;
    }
}