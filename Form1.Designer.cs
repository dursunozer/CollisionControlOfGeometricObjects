namespace NDPOdev2._4
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
            label1 = new Label();
            btnCizdirme = new Button();
            btnCarpisma = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 48);
            label1.Name = "label1";
            label1.Size = new Size(285, 23);
            label1.TabIndex = 1;
            label1.Text = "Hangi İşlemi Yapmak İstiyorsunuz?";
            // 
            // btnCizdirme
            // 
            btnCizdirme.BackColor = SystemColors.ActiveBorder;
            btnCizdirme.Location = new Point(75, 96);
            btnCizdirme.Name = "btnCizdirme";
            btnCizdirme.Size = new Size(128, 65);
            btnCizdirme.TabIndex = 2;
            btnCizdirme.Text = "Şekil Çizdirme Bölümü";
            btnCizdirme.UseVisualStyleBackColor = false;
            btnCizdirme.Click += btnCizdirme_Click;
            // 
            // btnCarpisma
            // 
            btnCarpisma.BackColor = SystemColors.ActiveBorder;
            btnCarpisma.Location = new Point(232, 96);
            btnCarpisma.Name = "btnCarpisma";
            btnCarpisma.Size = new Size(128, 65);
            btnCarpisma.TabIndex = 3;
            btnCarpisma.Text = "Şekil Çarpıştırma Bölümü";
            btnCarpisma.UseVisualStyleBackColor = false;
            btnCarpisma.Click += btnCarpisma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(436, 241);
            Controls.Add(btnCarpisma);
            Controls.Add(btnCizdirme);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCizdirme;
        private Button btnCarpisma;
    }
}
