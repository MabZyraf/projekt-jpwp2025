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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            easy_mode = new Button();
            medium_mode = new Button();
            hard_mode = new Button();
            label1 = new Label();
            label2 = new Label();
            panelMenu = new Panel();
            panelGra = new Panel();
            menu = new Button();
            pauza = new Label();
            label4 = new Label();
            lblScore = new Label();
            panelMenu.SuspendLayout();
            panelGra.SuspendLayout();
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
            // panelGra
            // 
            panelGra.BackColor = Color.Transparent;
            panelGra.Controls.Add(menu);
            panelGra.Controls.Add(pauza);
            panelGra.Controls.Add(label4);
            panelGra.Controls.Add(lblScore);
            panelGra.Location = new Point(0, 0);
            panelGra.Name = "panelGra";
            panelGra.Size = new Size(1003, 712);
            panelGra.TabIndex = 7;
            panelGra.Paint += panelGra_Paint;
            // 
            // menu
            // 
            menu.BackColor = Color.RosyBrown;
            menu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Location = new Point(746, 18);
            menu.Name = "menu";
            menu.Size = new Size(244, 72);
            menu.TabIndex = 4;
            menu.Text = "menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // pauza
            // 
            pauza.AutoSize = true;
            pauza.BackColor = Color.IndianRed;
            pauza.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            pauza.Location = new Point(522, 18);
            pauza.Name = "pauza";
            pauza.Size = new Size(153, 65);
            pauza.TabIndex = 2;
            pauza.Text = "pauza";
            pauza.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(221, 18);
            label4.Name = "label4";
            label4.Size = new Size(235, 65);
            label4.TabIndex = 1;
            label4.Text = "serduszka";
            label4.Click += label4_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 712);
            Controls.Add(panelGra);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelGra.ResumeLayout(false);
            panelGra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button easy_mode;
        private Button medium_mode;
        private Button hard_mode;
        private Label label1;
        private Label label2;
        private Panel panelMenu;
        private Panel panelGra;
        private Label lblScore;
        private Label label4;
        private Label pauza;
        private Button menu;
    }
}