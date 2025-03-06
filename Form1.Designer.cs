namespace pokemondex3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnPikachu = new Button();
            btnMew = new Button();
            btnAlcremie = new Button();
            btnSwirlix = new Button();
            btnSylveon = new Button();
            btnWhismur = new Button();
            lbName = new Label();
            lbType = new Label();
            lbStats = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPikachu
            // 
            btnPikachu.BackColor = Color.Linen;
            btnPikachu.ForeColor = Color.FromArgb(64, 64, 64);
            btnPikachu.Location = new Point(34, 41);
            btnPikachu.Name = "btnPikachu";
            btnPikachu.Size = new Size(94, 29);
            btnPikachu.TabIndex = 1;
            btnPikachu.Text = "Pikachu";
            btnPikachu.UseVisualStyleBackColor = false;
            btnPikachu.Click += btnPikachu_Click;
            // 
            // btnMew
            // 
            btnMew.BackColor = Color.MistyRose;
            btnMew.ForeColor = Color.FromArgb(64, 64, 64);
            btnMew.Location = new Point(153, 41);
            btnMew.Name = "btnMew";
            btnMew.Size = new Size(94, 29);
            btnMew.TabIndex = 2;
            btnMew.Text = "Mew";
            btnMew.UseVisualStyleBackColor = false;
            btnMew.Click += btnMew_Click;
            // 
            // btnAlcremie
            // 
            btnAlcremie.BackColor = Color.Linen;
            btnAlcremie.ForeColor = Color.FromArgb(64, 64, 64);
            btnAlcremie.Location = new Point(275, 41);
            btnAlcremie.Name = "btnAlcremie";
            btnAlcremie.Size = new Size(94, 29);
            btnAlcremie.TabIndex = 3;
            btnAlcremie.Text = "Alcremie";
            btnAlcremie.UseVisualStyleBackColor = false;
            btnAlcremie.Click += btnAlcremie_Click;
            // 
            // btnSwirlix
            // 
            btnSwirlix.BackColor = Color.MistyRose;
            btnSwirlix.ForeColor = Color.FromArgb(64, 64, 64);
            btnSwirlix.Location = new Point(396, 41);
            btnSwirlix.Name = "btnSwirlix";
            btnSwirlix.Size = new Size(94, 29);
            btnSwirlix.TabIndex = 4;
            btnSwirlix.Text = "Swirlix";
            btnSwirlix.UseVisualStyleBackColor = false;
            btnSwirlix.Click += btnSwirlix_Click;
            // 
            // btnSylveon
            // 
            btnSylveon.BackColor = Color.Linen;
            btnSylveon.ForeColor = Color.FromArgb(64, 64, 64);
            btnSylveon.Location = new Point(516, 41);
            btnSylveon.Name = "btnSylveon";
            btnSylveon.Size = new Size(94, 29);
            btnSylveon.TabIndex = 5;
            btnSylveon.Text = "Sylveon";
            btnSylveon.UseVisualStyleBackColor = false;
            btnSylveon.Click += btnSylveon_Click;
            // 
            // btnWhismur
            // 
            btnWhismur.BackColor = Color.MistyRose;
            btnWhismur.ForeColor = Color.FromArgb(64, 64, 64);
            btnWhismur.Location = new Point(639, 41);
            btnWhismur.Name = "btnWhismur";
            btnWhismur.Size = new Size(94, 29);
            btnWhismur.TabIndex = 6;
            btnWhismur.Text = "Whismur";
            btnWhismur.UseVisualStyleBackColor = false;
            btnWhismur.Click += btnWhismur_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BorderStyle = BorderStyle.FixedSingle;
            lbName.ForeColor = Color.FromArgb(64, 64, 64);
            lbName.Location = new Point(355, 97);
            lbName.Name = "lbName";
            lbName.Size = new Size(51, 22);
            lbName.TabIndex = 7;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.BorderStyle = BorderStyle.FixedSingle;
            lbType.ForeColor = Color.FromArgb(64, 64, 64);
            lbType.Location = new Point(355, 125);
            lbType.Name = "lbType";
            lbType.Size = new Size(42, 22);
            lbType.TabIndex = 8;
            lbType.Text = "Type";
            // 
            // lbStats
            // 
            lbStats.AutoSize = true;
            lbStats.ForeColor = Color.FromArgb(64, 64, 64);
            lbStats.Location = new Point(355, 160);
            lbStats.Name = "lbStats";
            lbStats.Size = new Size(75, 20);
            lbStats.TabIndex = 9;
            lbStats.Text = "BasicStats";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(766, 450);
            Controls.Add(lbStats);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(btnWhismur);
            Controls.Add(btnSylveon);
            Controls.Add(btnSwirlix);
            Controls.Add(btnAlcremie);
            Controls.Add(btnMew);
            Controls.Add(btnPikachu);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPikachu;
        private Button btnMew;
        private Button btnAlcremie;
        private Button btnSwirlix;
        private Button btnSylveon;
        private Button btnWhismur;
        private Label lbName;
        private Label lbType;
        private Label lbStats;
    }
}
