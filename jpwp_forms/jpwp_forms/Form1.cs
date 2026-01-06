using System.Numerics;

namespace jpwp_forms
{
    public enum Difficulty
    {
        Easy, Medium, Hard
    }
    public partial class Form1 : Form
    {
        private Avatar player;

        private int speed;  //difficulty
        private int points;
        private int score = 0;
        private int image;
        Difficulty currentDiff = Difficulty.Easy;
        int[] pasyY = { 150, 340, 530 };

        Random budda = new Random();

        List<Food> listaJedzenia = new List<Food>();

        public Form1()
        {
            InitializeComponent();
            player = new Avatar(35, 340);

        }

        private void GameMode(Difficulty mode)
        {
            switch (mode)   //difficulty setup
            {
                case Difficulty.Easy:
                    currentDiff = Difficulty.Easy;
                    speed = 1;
                    points = 10;
                    image = 1;
                    this.BackgroundImage = Properties.Resources.t³o_easy;
                    break;

                case Difficulty.Medium:
                    currentDiff = Difficulty.Medium;
                    int los = budda.Next(1, 4);
                    switch (los)
                    {
                        case 1:
                            player.Pic = Properties.Resources.duck;
                            break;
                        case 2:
                            player.Pic = Properties.Resources.pigeon;
                            break;
                        case 3:
                            player.Pic = Properties.Resources.crow;
                            break;
                    }
                    speed = 2;
                    points = 20;
                    image = 2;
                    this.BackgroundImage = Properties.Resources.t³o_medium;
                    break;

                case Difficulty.Hard:
                    currentDiff = Difficulty.Hard;
                    speed = 3;
                    points = 50;
                    image = 3;
                    this.BackgroundImage = Properties.Resources.t³o_hard;
                    break;

            }
            panelMenu.Visible = false;
            panelGra.Visible = true;
            FoodWave();
            panelGra.Invalidate();
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
            e.Graphics.DrawImage(player.Pic, player.X, player.Y, player.Width, player.Height);
            foreach (var item in listaJedzenia)
            {
                e.Graphics.DrawImage(item.PicF, item.X, item.Y, item.Width,item.Height);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (panelGra.Visible == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (player.Y > 150)
                    { player.GoUp(); }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (player.Y < 530)
                    { player.GoDown(); }
                }

                // BARDZO WA¯NE:
                // Po zmianie pozycji musimy natychmiast odœwie¿yæ widok,
                // ¿eby zobaczyæ ruch na ekranie.
                panelGra.Invalidate();
            }
        }
        private void FoodWave() 
        {
            int goodLine = budda.Next(0, 3);
            int fortuneFood = budda.Next(1, 5);
            int unFortuneFood1 = budda.Next(1, 5);
            int unFortuneFood2 = ((unFortuneFood1 * fortuneFood) % 4)+1;
            int licznikZlych = 0;
            for (int i = 0; i < 3; i++)
            {
                bool goodFood=false;

                if (i == goodLine)
                {
                    goodFood = true; 
                }
                else
                {
                    goodFood = false;
                    licznikZlych++;
                }

                Image wybranyObrazek = null;

                switch (currentDiff)
                {
                    case Difficulty.Easy:
                        if (goodFood) wybranyObrazek = Properties.Resources.t³o_easy;
                        else wybranyObrazek = Properties.Resources.t³o_easy;
                        break;

                    case Difficulty.Medium:
                        if (goodFood)
                        {
                            switch (fortuneFood)
                            {
                                case 1:
                                    wybranyObrazek = Properties.Resources.apple;
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.carrot;
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.nuts;
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.sunflower;
                                    break;
                            }
                        }
                        else
                        {
                            int aktualnyPech;
                            if (licznikZlych == 1) aktualnyPech = unFortuneFood1;
                            else aktualnyPech = unFortuneFood2;

                            switch (aktualnyPech)
                            {
                                case 1:
                                    wybranyObrazek = Properties.Resources.bread;
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.chips;
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.milk;
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.pasta;
                                    break;
                            }
                        }
                            break;

                    case Difficulty.Hard:
                                if (goodFood) wybranyObrazek = Properties.Resources.t³o_hard;
                                else wybranyObrazek = Properties.Resources.t³o_hard;
                                break;
                            }
                            Food next = new Food(500, pasyY[i], wybranyObrazek, goodFood);
                            listaJedzenia.Add(next);


                        }
        }
    }
}