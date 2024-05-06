namespace NDPOdev2._4
{
    partial class Cizdirme
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
            btnNokta = new Button();
            btnPrizma = new Button();
            btnDikdortgen = new Button();
            btnCember = new Button();
            btnKure = new Button();
            btnSilindir = new Button();
            btnYuzey = new Button();
            btnDortgen = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNokta
            // 
            btnNokta.BackColor = SystemColors.ActiveCaption;
            btnNokta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNokta.Location = new Point(27, 63);
            btnNokta.Name = "btnNokta";
            btnNokta.Size = new Size(188, 45);
            btnNokta.TabIndex = 1;
            btnNokta.Text = "Nokta";
            btnNokta.UseVisualStyleBackColor = false;
            btnNokta.Click += btnNokta_Click;
            // 
            // btnPrizma
            // 
            btnPrizma.BackColor = SystemColors.ActiveCaption;
            btnPrizma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrizma.Location = new Point(238, 63);
            btnPrizma.Name = "btnPrizma";
            btnPrizma.Size = new Size(188, 45);
            btnPrizma.TabIndex = 2;
            btnPrizma.Text = "Dikdörtgen Prizma";
            btnPrizma.UseVisualStyleBackColor = false;
            btnPrizma.Click += btnPrizma_Click;
            // 
            // btnDikdortgen
            // 
            btnDikdortgen.BackColor = SystemColors.ActiveCaption;
            btnDikdortgen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDikdortgen.Location = new Point(27, 127);
            btnDikdortgen.Name = "btnDikdortgen";
            btnDikdortgen.Size = new Size(188, 45);
            btnDikdortgen.TabIndex = 3;
            btnDikdortgen.Text = "Dikdörtgen";
            btnDikdortgen.UseVisualStyleBackColor = false;
            btnDikdortgen.Click += btnDikdortgen_Click;
            // 
            // btnCember
            // 
            btnCember.BackColor = SystemColors.ActiveCaption;
            btnCember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCember.Location = new Point(27, 194);
            btnCember.Name = "btnCember";
            btnCember.Size = new Size(188, 45);
            btnCember.TabIndex = 4;
            btnCember.Text = "Cember";
            btnCember.UseVisualStyleBackColor = false;
            btnCember.Click += btnCember_Click;
            // 
            // btnKure
            // 
            btnKure.BackColor = SystemColors.ActiveCaption;
            btnKure.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKure.Location = new Point(27, 259);
            btnKure.Name = "btnKure";
            btnKure.Size = new Size(188, 45);
            btnKure.TabIndex = 5;
            btnKure.Text = "Küre";
            btnKure.UseVisualStyleBackColor = false;
            btnKure.Click += btnKure_Click;
            // 
            // btnSilindir
            // 
            btnSilindir.BackColor = SystemColors.ActiveCaption;
            btnSilindir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSilindir.Location = new Point(238, 127);
            btnSilindir.Name = "btnSilindir";
            btnSilindir.Size = new Size(188, 45);
            btnSilindir.TabIndex = 6;
            btnSilindir.Text = "Silindir";
            btnSilindir.UseVisualStyleBackColor = false;
            btnSilindir.Click += btnSilindir_Click;
            // 
            // btnYuzey
            // 
            btnYuzey.BackColor = SystemColors.ActiveCaption;
            btnYuzey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYuzey.Location = new Point(238, 194);
            btnYuzey.Name = "btnYuzey";
            btnYuzey.Size = new Size(188, 45);
            btnYuzey.TabIndex = 7;
            btnYuzey.Text = "Yüzey";
            btnYuzey.UseVisualStyleBackColor = false;
            btnYuzey.Click += btnYuzey_Click;
            // 
            // btnDortgen
            // 
            btnDortgen.BackColor = SystemColors.ActiveCaption;
            btnDortgen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDortgen.Location = new Point(238, 259);
            btnDortgen.Name = "btnDortgen";
            btnDortgen.Size = new Size(188, 45);
            btnDortgen.TabIndex = 8;
            btnDortgen.Text = "Dörtgen";
            btnDortgen.UseVisualStyleBackColor = false;
            btnDortgen.Click += btnDortgen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 19);
            label1.Name = "label1";
            label1.Size = new Size(301, 23);
            label1.TabIndex = 9;
            label1.Text = "Hangi Nesneyi Çizdirmek İstiyorsun?";
            // 
            // Cizdirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(451, 368);
            Controls.Add(label1);
            Controls.Add(btnDortgen);
            Controls.Add(btnYuzey);
            Controls.Add(btnSilindir);
            Controls.Add(btnKure);
            Controls.Add(btnCember);
            Controls.Add(btnDikdortgen);
            Controls.Add(btnPrizma);
            Controls.Add(btnNokta);
            Name = "Cizdirme";
            Text = "Cizdirme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNokta;
        private Button btnPrizma;
        private Button btnDikdortgen;
        private Button btnCember;
        private Button btnKure;
        private Button btnSilindir;
        private Button btnYuzey;
        private Button btnDortgen;
        private Label label1;
    }
}