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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnexit2
            // 
            this.Btnexit2.BackColor = System.Drawing.Color.Red;
            this.Btnexit2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexit2.Location = new System.Drawing.Point(658, 12);
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntelapc
            // 
            this.btntelapc.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntelapc.Location = new System.Drawing.Point(12, 12);
            this.btntelapc.Name = "btntelapc";
            this.btntelapc.Size = new System.Drawing.Size(518, 84);
            this.btntelapc.TabIndex = 2;
            this.btntelapc.Text = "RECURSOS";
            this.btntelapc.UseVisualStyleBackColor = true;
            this.btntelapc.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(518, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = "RECORDES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(518, 84);
            this.button3.TabIndex = 4;
            this.button3.Text = "EXTRAS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(518, 84);
            this.button4.TabIndex = 5;
            this.button4.Text = "CRÉDITOS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LanHouseSystem.Properties.Resources.rr;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}