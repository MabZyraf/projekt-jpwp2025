namespace jpwp_forms
{
    partial class Form1 : Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            easy_mode = new Button();
            medium_mode = new Button();
            hard_mode = new Button();
            label1 = new Label();
            label2 = new Label();
            panelMenu = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            menu = new Button();
            shelfDown = new PictureBox();
            shelfMid = new PictureBox();
            shelfTop = new PictureBox();
            shelfBorder = new PictureBox();
            avatarPlaceTop = new PictureBox();
            avatarPlaceMid = new PictureBox();
            avatarPlaceDown = new PictureBox();
            panelGra = new Panel();
            heart3 = new PictureBox();
            heart2 = new PictureBox();
            heart1 = new PictureBox();
            btnPause = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shelfDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shelfMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shelfTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shelfBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceDown).BeginInit();
            panelGra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart1).BeginInit();
            SuspendLayout();
            // 
            // easy_mode
            // 
            easy_mode.BackColor = Color.FromArgb(255, 224, 192);
            easy_mode.Location = new Point(-3, 273);
            easy_mode.Name = "easy_mode";
            easy_mode.Size = new Size(1004, 85);
            easy_mode.TabIndex = 0;
            easy_mode.Text = "Pet (Easy)";
            easy_mode.UseVisualStyleBackColor = false;
            easy_mode.Click += easy_Click;
            // 
            // medium_mode
            // 
            medium_mode.BackColor = Color.FromArgb(255, 192, 128);
            medium_mode.Location = new Point(-3, 401);
            medium_mode.Name = "medium_mode";
            medium_mode.Size = new Size(1004, 85);
            medium_mode.TabIndex = 1;
            medium_mode.Text = "Bird (Medium)";
            medium_mode.UseVisualStyleBackColor = false;
            medium_mode.Click += medium_Click;
            // 
            // hard_mode
            // 
            hard_mode.BackColor = Color.FromArgb(255, 128, 0);
            hard_mode.Location = new Point(-3, 536);
            hard_mode.Name = "hard_mode";
            hard_mode.Size = new Size(1004, 85);
            hard_mode.TabIndex = 2;
            hard_mode.Text = "Wildlife (Hard)";
            hard_mode.UseVisualStyleBackColor = false;
            hard_mode.Click += hard_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("DejaVu Sans Condensed", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(1000, 140);
            label1.TabIndex = 5;
            label1.Text = "WILD BREAKFAST";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(346, 177);
            label2.Name = "label2";
            label2.Size = new Size(320, 54);
            label2.TabIndex = 6;
            label2.Text = "Choose difficulty";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(easy_mode);
            panelMenu.Controls.Add(medium_mode);
            panelMenu.Controls.Add(hard_mode);
            panelMenu.Location = new Point(-4, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1009, 715);
            panelMenu.TabIndex = 7;
            panelMenu.Paint += panel1_Paint;
            // 
            // timer
            // 
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.IndianRed;
            lblScore.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(12, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(191, 65);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score: x";
            lblScore.Click += label3_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.RosyBrown;
            menu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Location = new Point(746, 12);
            menu.Name = "menu";
            menu.Size = new Size(244, 72);
            menu.TabIndex = 4;
            menu.Text = "menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // shelfDown
            // 
            shelfDown.BackColor = Color.FromArgb(128, 64, 0);
            shelfDown.Location = new Point(10, 680);
            shelfDown.Name = "shelfDown";
            shelfDown.Size = new Size(975, 20);
            shelfDown.TabIndex = 9;
            shelfDown.TabStop = false;
            shelfDown.Click += pictureBox1_Click;
            // 
            // shelfMid
            // 
            shelfMid.BackColor = Color.FromArgb(128, 64, 0);
            shelfMid.Location = new Point(10, 490);
            shelfMid.Name = "shelfMid";
            shelfMid.Size = new Size(975, 20);
            shelfMid.TabIndex = 10;
            shelfMid.TabStop = false;
            // 
            // shelfTop
            // 
            shelfTop.BackColor = Color.FromArgb(128, 64, 0);
            shelfTop.Location = new Point(10, 300);
            shelfTop.Name = "shelfTop";
            shelfTop.Size = new Size(975, 20);
            shelfTop.TabIndex = 11;
            shelfTop.TabStop = false;
            // 
            // shelfBorder
            // 
            shelfBorder.BackColor = Color.FromArgb(128, 64, 0);
            shelfBorder.Location = new Point(10, 110);
            shelfBorder.Name = "shelfBorder";
            shelfBorder.Size = new Size(975, 20);
            shelfBorder.TabIndex = 12;
            shelfBorder.TabStop = false;
            // 
            // avatarPlaceTop
            // 
            avatarPlaceTop.BackColor = Color.Transparent;
            avatarPlaceTop.Location = new Point(35, 150);
            avatarPlaceTop.Name = "avatarPlaceTop";
            avatarPlaceTop.Size = new Size(160, 130);
            avatarPlaceTop.TabIndex = 13;
            avatarPlaceTop.TabStop = false;
            // 
            // avatarPlaceMid
            // 
            avatarPlaceMid.BackColor = Color.Transparent;
            avatarPlaceMid.Location = new Point(35, 340);
            avatarPlaceMid.Name = "avatarPlaceMid";
            avatarPlaceMid.Size = new Size(160, 130);
            avatarPlaceMid.TabIndex = 14;
            avatarPlaceMid.TabStop = false;
            // 
            // avatarPlaceDown
            // 
            avatarPlaceDown.BackColor = Color.Transparent;
            avatarPlaceDown.Location = new Point(35, 530);
            avatarPlaceDown.Name = "avatarPlaceDown";
            avatarPlaceDown.Size = new Size(160, 130);
            avatarPlaceDown.TabIndex = 15;
            avatarPlaceDown.TabStop = false;
            // 
            // panelGra
            // 
            panelGra.BackColor = Color.Transparent;
            panelGra.Controls.Add(heart3);
            panelGra.Controls.Add(heart2);
            panelGra.Controls.Add(heart1);
            panelGra.Controls.Add(btnPause);
            panelGra.Controls.Add(avatarPlaceDown);
            panelGra.Controls.Add(avatarPlaceMid);
            panelGra.Controls.Add(avatarPlaceTop);
            panelGra.Controls.Add(shelfBorder);
            panelGra.Controls.Add(shelfTop);
            panelGra.Controls.Add(shelfMid);
            panelGra.Controls.Add(shelfDown);
            panelGra.Controls.Add(menu);
            panelGra.Controls.Add(lblScore);
            panelGra.Location = new Point(0, 0);
            panelGra.Name = "panelGra";
            panelGra.Size = new Size(1003, 712);
            panelGra.TabIndex = 7;
            panelGra.Paint += panelGra_Paint;
            // 
            // heart3
            // 
            heart3.Image = Properties.Resources.hearts;
            heart3.Location = new Point(480, 9);
            heart3.Name = "heart3";
            heart3.Size = new Size(132, 86);
            heart3.SizeMode = PictureBoxSizeMode.Zoom;
            heart3.TabIndex = 19;
            heart3.TabStop = false;
            heart3.Click += heart3_Click;
            // 
            // heart2
            // 
            heart2.Image = Properties.Resources.hearts;
            heart2.Location = new Point(376, 9);
            heart2.Name = "heart2";
            heart2.Size = new Size(132, 86);
            heart2.SizeMode = PictureBoxSizeMode.Zoom;
            heart2.TabIndex = 18;
            heart2.TabStop = false;
            // 
            // heart1
            // 
            heart1.Image = Properties.Resources.hearts;
            heart1.Location = new Point(271, 9);
            heart1.Name = "heart1";
            heart1.Size = new Size(132, 86);
            heart1.SizeMode = PictureBoxSizeMode.Zoom;
            heart1.TabIndex = 17;
            heart1.TabStop = false;
            heart1.Click += heart1_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(610, 30);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(112, 34);
            btnPause.TabIndex = 16;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 712);
            Controls.Add(panelGra);
            Controls.Add(panelMenu);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shelfDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)shelfMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)shelfTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)shelfBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatarPlaceDown).EndInit();
            panelGra.ResumeLayout(false);
            panelGra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button easy_mode;
        private Button medium_mode;
        private Button hard_mode;
        private Label label1;
        private Label label2;
        private Panel panelMenu;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer;
        private Label lblScore;
        private Button menu;
        private PictureBox shelfDown;
        private PictureBox shelfMid;
        private PictureBox shelfTop;
        private PictureBox shelfBorder;
        private PictureBox avatarPlaceTop;
        private PictureBox avatarPlaceMid;
        private PictureBox avatarPlaceDown;
        private Panel panelGra;
        private Button btnPause;
        private PictureBox heart3;
        private PictureBox heart2;
        private PictureBox heart1;
    }
}