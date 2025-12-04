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
            SuspendLayout();
            // 
            // easy_mode
            // 
            easy_mode.BackColor = Color.FromArgb(255, 224, 192);
            easy_mode.Location = new Point(1, 275);
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
            medium_mode.Location = new Point(1, 400);
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
            hard_mode.Location = new Point(1, 525);
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
            label1.Location = new Point(5, 28);
            label1.Name = "label1";
            label1.Size = new Size(1000, 200);
            label1.TabIndex = 5;
            label1.Text = "WILD BREAKFAST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(334, 160);
            label2.Name = "label2";
            label2.Size = new Size(320, 54);
            label2.TabIndex = 6;
            label2.Text = "Choose difficulty";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 712);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hard_mode);
            Controls.Add(medium_mode);
            Controls.Add(easy_mode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button easy_mode;
        private Button medium_mode;
        private Button hard_mode;
        private Label label1;
        private Label label2;
    }
}