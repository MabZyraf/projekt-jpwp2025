namespace jpwp_forms
{
    public enum Difficulty
    {
        Easy, Medium, Hard
    }
    public partial class Form1 : Form
    {
        private Avatar gracz;

        private int speed;  //difficulty
        private int points;
        private int score = 0;
        private int image;

        public Form1()
        {
            InitializeComponent();
            gracz = new Avatar();

        }

        private void GameMode(Difficulty mode)
        {
            switch (mode)   //difficulty setup
            {
                case Difficulty.Easy:
                    speed = 1;
                    points = 10;
                    image = 1;
                    this.BackgroundImage = Properties.Resources.t³o_easy;
                    break;

                case Difficulty.Medium:
                    speed = 2;
                    points = 20;
                    image = 2;
                    this.BackgroundImage = Properties.Resources.t³o_medium;
                    break;

                case Difficulty.Hard:
                    speed = 3;
                    points = 50;
                    image = 3;
                    this.BackgroundImage = Properties.Resources.t³o_hard;
                    break;

            }
            panelMenu.Visible = false;
            panelGra.Visible = true;
            GameWindow();   //gaming interface 
            PointCounter();
            this.Focus();   //keyboard control
        }
        private void GameWindow()
        {
            //gaming interface
        }

        private void PointCounter()
        {
            //
        }

        private void easy_Click(object sender, EventArgs e)
        {
            GameMode(Difficulty.Easy);
        }

        private void medium_Click(object sender, EventArgs e)
        {
            GameMode(Difficulty.Medium);
        }

        private void hard_Click(object sender, EventArgs e)
        {
            GameMode(Difficulty.Hard);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            //gameTimer.Stop();
            panelGra.Visible = false;
            panelMenu.Visible = true;
            panelMenu.BringToFront();

        }

        private void panelGra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources. gracz.X, gracz.Y, 100, 100);
            foreach (var item in listaJedzenia)
            {
                e.Graphics.DrawImage(item.Obrazek, item.X, item.Y, 50, 50);
            }
        }
    }
}