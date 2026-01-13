using System.Numerics;
using System.IO;

namespace jpwp_forms
{
    public enum Difficulty
    {
        Easy, Medium, Hard
    }
    public partial class Form1 : Form
    {
        private Avatar player;
        private int tickCounter = 0;
        private int hearts = 3;
        private int speed;  //difficulty
        private int points;
        private int score = 0;
        private int image;
        Difficulty currentDiff = Difficulty.Easy;
        int[] pasyY = { 150, 340, 530 };

        Random budda = new Random();

        List<Food> listaJedzenia = new List<Food>();
        List<string> outro = new List<string>();

        public Form1()
        {
            InitializeComponent();
            player = new Avatar(35, 340);
            // brak lagów
            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null, panelGra, new object[] { true });
            ReadScore();

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

            hearts = 3;
            LosingHearts();

            score = 0;
            listaJedzenia.Clear();
            outro.Clear();

            timer.Start();  //start gry


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
            ReadScore();

        }

        private void panelGra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(player.Pic, player.X, player.Y, player.Width, player.Height);
            foreach (var item in listaJedzenia)
            {
                e.Graphics.DrawImage(item.PicF, item.X, item.Y, item.Width, item.Height);
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { // sterowanie góra dó³
            if (timer.Enabled == true)
            {
                if (keyData == Keys.Up)
                {
                    if (player.Y > 150) player.GoUp();
                    panelGra.Invalidate();
                    return true;
                }

                if (keyData == Keys.Down)
                {
                    if (player.Y < 530) player.GoDown();
                    panelGra.Invalidate();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FoodWave()
        {
            int goodLine = budda.Next(0, 3);
            int fortuneFood = budda.Next(1, 5);
            int unFortuneFood1 = budda.Next(1, 5);
            int unFortuneFood2 = ((unFortuneFood1 * fortuneFood) % 4) + 1;
            int licznikZlych = 0;
            for (int i = 0; i < 3; i++)
            {
                bool goodFood = false;

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
                string theAnwser = " ";

                switch (currentDiff)
                {
                    case Difficulty.Easy:
                        if (goodFood)
                        {
                            switch (fortuneFood)
                            {
                                case 1:
                                    wybranyObrazek = Properties.Resources.cookedMeat;
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.carrot;
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.pumpkin;
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.whiteRice;
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.petFood;
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
                                    wybranyObrazek = Properties.Resources.chocolate;
                                    theAnwser = "Chocolate: Contains theobromine; causes vomiting, seizures, and heart arrhythmias.";
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.grapes;
                                    theAnwser = "Grapes & Raisins: Can cause sudden, acute kidney failure, especially in dogs.";
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.onion;
                                    theAnwser = "Onion: Damages red blood cells causing hemolytic anemia.";
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.garlic;
                                    theAnwser = "Garlic: 5 times more potent than onions; highly toxic to red blood cells.";
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.alcohol;
                                    theAnwser = "Alcohol: Causes severe liver damage, coma, and respiratory failure.";
                                    break;
                                case 6:
                                    wybranyObrazek = Properties.Resources.coffee;
                                    theAnwser = "Caffeine: Leads to hypertension, tremors, and dangerous heart rhythms.";
                                    break;
                                case 7:
                                    wybranyObrazek = Properties.Resources.fishBones;
                                    theAnwser = "Fish Bones: Sharp and small, they can lodge in the throat or intestines.";
                                    break;
                                case 8:
                                    wybranyObrazek = Properties.Resources.chips;
                                    theAnwser = "Salty Snacks: Excessive salt leads to sodium ion poisoning and brain swelling.";
                                    break;
                                case 9:
                                    wybranyObrazek = Properties.Resources.avocado;
                                    theAnwser = "Avocado: Contains persin (toxic) and the pit presents a major choking hazard.";
                                    break;
                                case 10:
                                    wybranyObrazek = Properties.Resources.fruitPits;
                                    theAnwser = "Fruit Pits: Contain cyanide and can cause intestinal blockages.";
                                    break;
                                case 11:
                                    wybranyObrazek = Properties.Resources.moldyTrash;
                                    theAnwser = "Moldy Food: Tremorgenic mycotoxins in mold cause severe muscle tremors.";
                                    break;
                                case 12:
                                    wybranyObrazek = Properties.Resources.milk;
                                    theAnwser = "Milk: Most adult dogs and cats are lactose intolerant, leading to digestive upset.";
                                    break;
                                case 13:
                                    wybranyObrazek = Properties.Resources.rawFish;
                                    theAnwser = "Raw Fish: May contain parasites or destroy Vitamin B1 (thiamine deficiency).";
                                    break;
                            }
                        }
                        break;

                    case Difficulty.Medium:
                        if (goodFood)
                        {
                            switch (fortuneFood)
                            {
                                case 1:
                                    wybranyObrazek = Properties.Resources.sunflower;
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.carrot;
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.millet;
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.nuts;
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.driedFruit;
                                    break;
                                case 6:
                                    wybranyObrazek = Properties.Resources.apple;
                                    break;
                                case 7:
                                    wybranyObrazek = Properties.Resources.worms;
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
                                    theAnwser = "Bread: Provides empty calories, causes 'angel wing' deformity, and risks sour crop.";
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.milk;
                                    theAnwser = "Milk: Unlike mammals, birds cannot digeste lactose.";
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.pasta;
                                    theAnwser = "Pasta: Both cooked and raw pasta is extremly dangerous for birds.";
                                    break;                               
                                case 4:
                                    wybranyObrazek = Properties.Resources.avocado;
                                    theAnwser = "Avocado: Contains persin, which causes heart failure and respiratory distress in birds.";
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.chocolate;
                                    theAnwser = "Chocolate: Contains theobromine, which induces vomiting, diarrhea, and seizures.";
                                    break;
                                case 6:
                                    wybranyObrazek = Properties.Resources.coffee;
                                    theAnwser = "Caffeine: Causes cardiac arrest and hyperactivity; highly toxic.";
                                    break;
                                case 7:
                                    wybranyObrazek = Properties.Resources.alcohol;
                                    theAnwser = "Alcohol: Depresses organ systems and can be fatal even in tiny drops.";
                                    break;
                                case 8:
                                    wybranyObrazek = Properties.Resources.onion;
                                    theAnwser = "Onion: Contains sulfur compounds that destroy red blood cells, causing anemia.";
                                    break;
                                case 9:
                                    wybranyObrazek = Properties.Resources.garlic;
                                    theAnwser = "Garlic: Similar to onions but less potent; causes anemia and weakness.";
                                    break;
                                case 10:
                                    wybranyObrazek = Properties.Resources.appleSeeds;
                                    theAnwser = "Fruit Pits/Seeds: Contain cyanide which is lethal to birds.";
                                    break;
                                case 11:
                                    wybranyObrazek = Properties.Resources.rawBeans;
                                    theAnwser = "Raw Beans: Contain hemagglutinin (lectin), which is highly toxic unless cooked.";
                                    break;
                                case 12:
                                    wybranyObrazek = Properties.Resources.salt;
                                    theAnwser = "Salt: Deadly even in small amounts; causes dehydration and kidney failure.";
                                    break;
                                case 13:
                                    wybranyObrazek = Properties.Resources.chips;
                                    break;
                                case 14:
                                    wybranyObrazek = Properties.Resources.friedFood;
                                    theAnwser = "Fried Food: Can cause obesity and skin issues; birds cannot process trans fats.";
                                    break;
                                case 15:
                                    wybranyObrazek = Properties.Resources.rhubarb;
                                    theAnwser = "Rhubarb: Contains oxalates that cause immediate kidney damage.";
                                    break;
                                case 16:
                                    wybranyObrazek = Properties.Resources.mushrooms;
                                    theAnwser = "Mushrooms: Many varieties cause liver failure and digestive upset.";
                                    break;
                                case 17:
                                    wybranyObrazek = Properties.Resources.greenTomato;
                                    theAnwser = "Green Tomato parts: Stems and leaves contain solanine, a neurotoxin.";
                                    break;
                                case 18:
                                    wybranyObrazek = Properties.Resources.dryCoconut;
                                    theAnwser = "Desiccated Coconut: Swells inside the crop and can cause suffocation.";
                                    break;
                            }
                        }
                        break;

                    case Difficulty.Hard:
                        if (goodFood)
                        {
                            switch (fortuneFood)
                            {
                                case 1:
                                    wybranyObrazek = Properties.Resources.hay;
                                    break;
                                case 2:
                                    wybranyObrazek = Properties.Resources.carrot;
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.branches;
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.nuts;
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.acorns;
                                    break;
                                case 6:
                                    wybranyObrazek = Properties.Resources.herbs;
                                    break;
                                case 7:
                                    wybranyObrazek = Properties.Resources.driedLeaves;
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
                                    theAnwser = "Bread: Disrupts digestion causing lactic acidosis and fatal bloating.";
                                    break;
                                case 3:
                                    wybranyObrazek = Properties.Resources.sweets;
                                    theAnwser = "Sweets/Cookies: Sugar destroys the gut bacteria needed to digest grass.";
                                    break;
                                case 4:
                                    wybranyObrazek = Properties.Resources.potatoes;
                                    theAnwser = "Raw Potatoes: High starch content and solanine make them toxic and hard to digest.";
                                    break;
                                case 5:
                                    wybranyObrazek = Properties.Resources.onion;
                                    theAnwser = "Onion & Garlic: Cause immunosuppression and anaphylactic shock in some wild animals.";
                                    break;
                                case 6:
                                    wybranyObrazek = Properties.Resources.rhubarb;
                                    theAnwser = "Rhubarb Leaves: Extremely high in oxalates, causing kidney failure.";
                                    break;
                                case 7:
                                    wybranyObrazek = Properties.Resources.cabbage;
                                    theAnwser = "Cabbage: Ferments rapidly in the gut, causing gas and fatal bloating (GI Stasis).";
                                    break;
                                case 8:
                                    wybranyObrazek = Properties.Resources.lettuce;
                                    theAnwser = "Iceberg Lettuce: Contains lactucarium which can be harmful; has zero nutritional value.";
                                    break;
                                case 9:
                                    wybranyObrazek = Properties.Resources.avocado;
                                    theAnwser = "Avocado: Highly toxic to rabbits and horses causing respiratory congestion.";
                                    break;
                                case 10:
                                    wybranyObrazek = Properties.Resources.chocolate;
                                    theAnwser = "Chocolate: Theobromine is toxic to squirrels, rabbits, and deer alike.";
                                    break;
                                case 11:
                                    wybranyObrazek = Properties.Resources.friedFood;
                                    theAnwser = "Processed Food: Chemicals and preservatives are indigestible for wildlife.";
                                    break;
                                case 13:
                                    wybranyObrazek = Properties.Resources.milk;
                                    theAnwser = "Dairy Products: Adult herbivores lack the enzyme lactase; causes severe diarrhea.";
                                    break;
                                case 15:
                                    wybranyObrazek = Properties.Resources.citrus;
                                    theAnwser = "Citrus Fruits: High acidity can cause ulcers and digestive pain.";
                                    break;
                                case 16:
                                    wybranyObrazek = Properties.Resources.wiltedBranches;
                                    theAnwser = "Wilted Fruit Branches: Wilting leaves of stone fruits produce deadly cyanide.";
                                    break;
                                case 18:
                                    wybranyObrazek = Properties.Resources.corn;
                                    theAnwser = "Corn: Introducing high starch in winter causes rapid acidosis and death in deer.";
                                    break;
                                case 20:
                                    wybranyObrazek = Properties.Resources.fruitPits;
                                    theAnwser = "Fruit Pits: Cyanide content poses a significant poisoning risk.";
                                    break;
                                }
                            }
                        break;
                }
                if (wybranyObrazek == null) wybranyObrazek = Properties.Resources.apple;
                Food next = new Food(panelGra.Width + 50, pasyY[i], wybranyObrazek, goodFood);
                next.Anwser = theAnwser;
                listaJedzenia.Add(next);


            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tickCounter++;
            int hold = 70;
            if (currentDiff == Difficulty.Medium) hold = 50;
            if (currentDiff == Difficulty.Hard) hold = 30;
            if (tickCounter > hold)
            {
                FoodWave();
                tickCounter = 0;
            }
            for (int i = listaJedzenia.Count - 1; i >= 0; i--)
            {
                int vBonus = score / 50;
                var item = listaJedzenia[i];
                item.X -= speed * 8 + vBonus;
                Rectangle playerField = new Rectangle(player.X, player.Y, player.Width, player.Height);
                Rectangle foodField = new Rectangle(item.X, item.Y, 80, 80);

                if (playerField.IntersectsWith(foodField))
                {
                    if (item.Correct)
                    {
                        score += points;
                    }
                    else
                    {
                        hearts--;
                        LosingHearts();
                        outro.Add(item.Anwser);
                        if (hearts <= 0)
                        {
                            timer.Stop();
                            GameOver();
                            return;
                        }
                    }

                    listaJedzenia.RemoveAt(i);
                    continue;
                }
                if (item.X < -100)
                {
                    listaJedzenia.RemoveAt(i);
                }
            }
            panelGra.Invalidate();
            lblScore.Text = "Punkty: " + score;
        }

        private void GameOver()
        {
            timer.Stop();
            SaveScore();
            string feedback = "Game Over\nScore:" + score + "\n\nYour mistakes:\n";

            foreach (string mistake in outro)
            {
                feedback += "- " + mistake + "\n";
            }
            /*if (outro.Count == 0)
            {
                feedback += "Perfect score";
            }
            else
            {
                feedback += "You made " + outro.Count + "mistake/s";
            }*/
            MessageBox.Show(feedback);

            panelGra.Visible = false;
            panelMenu.Visible = true;
            ReadScore();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                btnPause.Text = "Pause";
                this.Focus();
            }
        }
        private void LosingHearts()
        {//aktualizacja serduszek
            if (hearts >= 1) heart1.Visible = true; else heart1.Visible = false;
            if (hearts >= 2) heart2.Visible = true; else heart2.Visible = false;
            if (hearts >= 3) heart3.Visible = true; else heart3.Visible = false;
        }

        private void heart3_Click(object sender, EventArgs e)
        {

        }

        private void heart1_Click(object sender, EventArgs e)
        {

        }

        private void lableRecord_Click(object sender, EventArgs e)
        {

        }
        private void SaveScore()
        {//aktualizacja rekordu
            int oldScore = 0;
            if (File.Exists("record.txt"))
            {
                string highScore = File.ReadAllText("record.txt");
                int.TryParse(highScore, out oldScore);
            }
            if (score > oldScore)
            {
                File.WriteAllText("record.txt", score.ToString());
            }
        }
        private void ReadScore()
        {
            if (File.Exists("record.txt"))
            {
                string highScore = File.ReadAllText("record.txt");
                lableRecord.Text = "Top score: " + highScore;
            }
            else
            {
                lableRecord.Text = "No game played";
            }
        }
    }
}