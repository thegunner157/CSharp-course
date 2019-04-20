using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domowe2
{
    public partial class Game : Form
    {

        int HowManyTurnsleft = 3;
        ///var whose turn
        int WhoseTurn = 1;
        /// <summary>
        /// Vars to hold a local result of game
        /// </summary>
        int ResultPlayer1=0;
        int ResultPlayer2=0;
        Shop shop;
        Main main;
        /// <summary>
        /// zmienne zapewniające nie wychodzenie wskaznika poza tablicy 
        /// </summary>
        bool firstPlayerleft = false;
        bool firstPlayerright = true;
        bool secondPlayerleft = false;
        bool secondPlayerright = true;
        /// <summary>
        /// zmienne wskazujace jak szybko ma sie zmieniac wskaznik
        /// </summary>
        int LengthofMoveFirstPlayer=10;
        int LengthofMoveSecondPlayer=10;
        /// <summary>
        /// Constuctor in which I remember pictures
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="par"></param>
        public Game(Shop parent, Main par)
        {
            InitializeComponent();
            shop = parent;
            main = par;
            if (main.dave.whichPlayer == 1)
            {
                pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/daveGame.jpg");
                pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/pete.png");
            }
            else
            {
                pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/pete.png");
                pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/daveGame.jpg");
            }
        }
        /// <summary>
        /// Function of shooting first player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShootButton_Click(object sender, EventArgs e)
        {
            FirstPlayerTimer.Stop();
            int place = ShootPointerPlayer1.Location.X;
            ResultPlayer1 += Math.Abs(place - 652);
            textBoxPlayer1Result.Text = ResultPlayer1.ToString();
            WhoseTurn = 2;

        }
        /// <summary>
        /// Behaviour of pointer during first Player try
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstPlayerTimer_Tick(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 1)
            {
                FirstPlayerTimer.Interval = 30- 5 * main.dave.slowerPointer;
            }
            else
            {
                FirstPlayerTimer.Interval =30- 5 * main.pete.slowerPointer;
            }
            if (firstPlayerright)
            {
                if (ShootPointerPlayer1.Location.X < 750)
                {
                    if(main.dave.whichPlayer==1)
                        ShootPointerPlayer1.Location = new Point(ShootPointerPlayer1.Location.X + LengthofMoveFirstPlayer-2* main.dave.approximationShoot, ShootPointerPlayer1.Location.Y);
                    else
                        ShootPointerPlayer1.Location = new Point(ShootPointerPlayer1.Location.X + LengthofMoveFirstPlayer - 2 * main.pete.approximationShoot, ShootPointerPlayer1.Location.Y);
                }
                else
                {
                    firstPlayerright = false;
                    firstPlayerleft = true;
                }
            }
            if (firstPlayerleft)
            {
                if (ShootPointerPlayer1.Location.X > 553)
                {
                    if (main.dave.whichPlayer == 1)
                        ShootPointerPlayer1.Location = new Point(ShootPointerPlayer1.Location.X - LengthofMoveFirstPlayer+ 2 * main.dave.approximationShoot, ShootPointerPlayer1.Location.Y);
                    else
                        ShootPointerPlayer1.Location = new Point(ShootPointerPlayer1.Location.X - LengthofMoveFirstPlayer + 2 * main.pete.approximationShoot, ShootPointerPlayer1.Location.Y);
                }
                else
                {
                    firstPlayerright = true;
                    firstPlayerleft = false;
                }
            }

        }
        /// <summary>
        /// Start pointer in First Player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTimer1button_Click(object sender, EventArgs e)
        {
            if (WhoseTurn == 1)
            {
                if (HowManyTurnsleft > 0)
                {
                    FirstPlayerTimer.Start();
                    ShootPointerPlayer2.Location = new Point(172, ShootPointerPlayer1.Location.Y);
                }
                else
                {
                    MessageBox.Show("End of rounds");
                }
            }
            else
            {
                MessageBox.Show("Not your turn");
            }
        }
        /// <summary>
        /// End round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            if (HowManyTurnsleft == 0)
            {
                shop.Visible = true;
                this.Visible = false;
                HowManyTurnsleft = 3;
                ResultPlayer1 = 0;
                ResultPlayer2 = 0;
                if (main.dave.whichPlayer == 1)
                {
                    shop.textBoxExperiencePlayer1.Text = main.dave.experience.ToString();
                    shop.textBoxMoneyPlayer1.Text = main.dave.money.ToString();
                    shop.textBoxExperiencePlayer2.Text = main.pete.experience.ToString();
                    shop.textBoxMoneyPlayer2.Text = main.pete.money.ToString();
                }
                else
                {
                    shop.textBoxExperiencePlayer1.Text = main.pete.experience.ToString();
                    shop.textBoxMoneyPlayer1.Text = main.pete.money.ToString();
                    shop.textBoxExperiencePlayer2.Text = main.dave.experience.ToString();
                    shop.textBoxMoneyPlayer2.Text = main.dave.money.ToString();
                }
            }
            else
            {
                MessageBox.Show("There are turns left");
            }
        }
        /// <summary>
        /// Behaviour of pointer during second Player try
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondPlayerTimer_Tick(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 2)
            {
                SecondPlayerTimer.Interval = 30 - 5 * main.dave.slowerPointer;
            }
            else
            {
                SecondPlayerTimer.Interval = 30 - 5 * main.pete.slowerPointer;
            }
            if (secondPlayerright)
            {
                if (ShootPointerPlayer2.Location.X < 369)
                {
                    if (main.dave.whichPlayer == 2)
                        ShootPointerPlayer2.Location = new Point(ShootPointerPlayer2.Location.X + LengthofMoveSecondPlayer- 2 * main.dave.approximationShoot, ShootPointerPlayer2.Location.Y);
                    else
                        ShootPointerPlayer2.Location = new Point(ShootPointerPlayer2.Location.X + LengthofMoveSecondPlayer - 2 * main.pete.approximationShoot, ShootPointerPlayer2.Location.Y);
                }
                else
                {
                    secondPlayerright = false;
                    secondPlayerleft = true;
                }
            }
            if (secondPlayerleft)
            {
                if (ShootPointerPlayer2.Location.X > 172)
                {
                    if (main.dave.whichPlayer == 2)
                        ShootPointerPlayer2.Location = new Point(ShootPointerPlayer2.Location.X - LengthofMoveSecondPlayer + 2 * main.dave.approximationShoot, ShootPointerPlayer2.Location.Y);
                    else
                        ShootPointerPlayer2.Location = new Point(ShootPointerPlayer2.Location.X - LengthofMoveSecondPlayer + 2 * main.pete.approximationShoot, ShootPointerPlayer2.Location.Y);
                }
                else
                {
                    secondPlayerright = true;
                    secondPlayerleft = false;
                }
            }
        }
        /// <summary>
        /// Start second Player pointer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTimerPlayer2button_Click(object sender, EventArgs e)
        {
            if (WhoseTurn == 2)
            {
                if (HowManyTurnsleft > 0)
                {
                    SecondPlayerTimer.Start();
                    ShootPointerPlayer1.Location = new Point(553, ShootPointerPlayer2.Location.Y);
                }
                else
                {
                    MessageBox.Show("End of rounds!");
                }
            }
            else
            {
                MessageBox.Show("Not your turn");
            }
        }
        /// <summary>
        /// second player shoot and what will happen after 3 rounds. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShootbuttonPlayer2_Click(object sender, EventArgs e)
        {
            SecondPlayerTimer.Stop();
            int place = ShootPointerPlayer2.Location.X;
            ResultPlayer2 += Math.Abs(place - 99-172);
            textBoxPlayer2Result.Text = ResultPlayer2.ToString();
            HowManyTurnsleft--;
            WhoseTurn = 1;
            if (HowManyTurnsleft == 0)
            {
                if (ResultPlayer1 > ResultPlayer2) {
                    if (main.dave.whichPlayer == 2)
                    {
                        main.dave.experience += 50;
                        main.dave.money += 40;
                        main.pete.experience += 15;
                    }
                    else
                    {
                        main.pete.experience += 50;
                        main.pete.money += 40;
                        main.dave.experience += 15;
                    }
                    MessageBox.Show("Player 2 won!");
                }
                else if(ResultPlayer1 < ResultPlayer2)
                {
                    if (main.dave.whichPlayer == 1)
                    {
                        main.dave.experience += 50;
                        main.dave.money += 40;
                        main.pete.experience += 15;
                    }
                    else
                    {
                        main.pete.experience += 50;
                        main.pete.money += 40;
                        main.dave.experience += 15;
                    }
                    MessageBox.Show("Player 1 won!");
                }
                else
                {
                    main.pete.experience += 30;
                    main.pete.money += 20;
                    main.dave.experience += 30;
                    main.dave.money += 20;
                    MessageBox.Show("It's a draw!");
                }
            }
           
        }
    }
}
