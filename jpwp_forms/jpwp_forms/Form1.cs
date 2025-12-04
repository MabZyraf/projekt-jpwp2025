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



    }
}