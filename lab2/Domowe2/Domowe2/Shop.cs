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
    public partial class Shop : Form
    {
        /// <summary>
        /// Prices of goods
        /// </summary>
        int priceSlowerPointerPlayer1 = 110;
        int priceSlowerPointerPlayer2 = 110;
        int priceBetterAccuracyPlayer1 = 140;
        int priceBetterAccuracyPlayer2 = 140;
        /// <summary>
        /// References to other forms
        /// </summary>
        Main main;
        Game openGame;
        /// <summary>
        /// Var to remember if it is first Game
        /// </summary>
        bool isFirstGame = false;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent"></param>
        public Shop(Main parent)
        {
            InitializeComponent();
            main = parent;
            if (main.dave.whichPlayer == 1)
            {
                labelPlayer1Name.Text = "Dave";
                labelPlayer2Name.Text = "Pete";
                pictureBoxPlayer1image.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/daveGame.jpg");
                pictureBoxPlayer2image.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/pete.png");
            }
            else
            {
                labelPlayer2Name.Text = "Dave";
                labelPlayer1Name.Text = "Pete";
                pictureBoxPlayer2image.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/daveGame.jpg");
                pictureBoxPlayer1image.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/pete.png");
            }
        }
        /// <summary>
        /// Buying betterAccuracy and SlowerPointer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ButtonBuySlowerPointerPlayer1_Click(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 1)
            {
                if (main.dave.slowerPointer < 5)
                {
                    if (main.dave.money >= priceSlowerPointerPlayer1)
                    {
                        main.dave.money -= priceSlowerPointerPlayer1;
                        priceSlowerPointerPlayer1 += 30;
                        buttonBuySlowerPointerPlayer1.Text = priceSlowerPointerPlayer1.ToString();
                        textBoxMoneyPlayer1.Text = main.dave.money.ToString();
                        main.dave.slowerPointer++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!");
                    }
                }
            }
            else
            {
                if (main.pete.slowerPointer < 5)
                {
                    if (main.pete.money >= priceSlowerPointerPlayer1)
                    {
                        main.pete.money -= priceSlowerPointerPlayer1;
                        priceSlowerPointerPlayer1 += 30;
                        buttonBuySlowerPointerPlayer1.Text = priceSlowerPointerPlayer1.ToString();
                        textBoxMoneyPlayer1.Text = main.pete.money.ToString();
                        main.pete.slowerPointer++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!");
                    }
                }
            }
        }

        private void ButtonBuySlowerPointerPlayer2_Click(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 2)
            {
                if (main.dave.slowerPointer < 5)
                {
                    if (main.dave.money >= priceSlowerPointerPlayer2)
                    {
                        main.dave.money -= priceSlowerPointerPlayer2;
                        priceSlowerPointerPlayer1 += 30;
                        buttonBuySlowerPointerPlayer2.Text = priceSlowerPointerPlayer2.ToString();
                        textBoxMoneyPlayer2.Text = main.dave.money.ToString();
                        main.dave.slowerPointer++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!");
                    }
                }
            }
            else
            {
                if (main.pete.slowerPointer < 5)
                {
                    if (main.pete.money >= priceSlowerPointerPlayer2)
                    {
                        main.pete.money -= priceSlowerPointerPlayer2;
                        priceSlowerPointerPlayer2 += 30;
                        buttonBuySlowerPointerPlayer2.Text = priceSlowerPointerPlayer2.ToString();
                        textBoxMoneyPlayer2.Text = main.pete.money.ToString();
                        main.pete.slowerPointer++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!");
                    }
                }
            }
        }

        private void ButtonBuyBetterAccPlayer1_Click(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 1)
            {
                if (main.dave.approximationShoot < 4)
                {
                    if (main.dave.experience >= priceBetterAccuracyPlayer1)
                    {
                        main.dave.experience -= priceBetterAccuracyPlayer1;
                        priceBetterAccuracyPlayer1 += 40;
                        buttonBuyBetterAccPlayer1.Text = priceBetterAccuracyPlayer1.ToString();
                        textBoxExperiencePlayer1.Text = main.dave.experience.ToString();
                        main.dave.approximationShoot++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough experience!");
                    }
                }
            }
            else
            {
                if (main.pete.approximationShoot < 4)
                {
                    if (main.pete.experience >= priceBetterAccuracyPlayer1)
                    {
                        main.pete.experience -= priceBetterAccuracyPlayer1;
                        priceBetterAccuracyPlayer1 += 40;
                        buttonBuyBetterAccPlayer1.Text = priceBetterAccuracyPlayer1.ToString();
                        textBoxExperiencePlayer1.Text = main.pete.experience.ToString();
                        main.pete.approximationShoot++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough experience!");
                    }
                }
            }
        }

        private void ButtonBuyBetterAccPlayer2_Click(object sender, EventArgs e)
        {
            if (main.dave.whichPlayer == 2)
            {
                if (main.dave.approximationShoot < 4)
                {
                    if (main.dave.experience >= priceBetterAccuracyPlayer2)
                    {
                        main.dave.experience -= priceBetterAccuracyPlayer2;
                        priceBetterAccuracyPlayer2 += 40;
                        buttonBuyBetterAccPlayer2.Text = priceBetterAccuracyPlayer2.ToString();
                        textBoxExperiencePlayer2.Text = main.dave.experience.ToString();
                        main.dave.approximationShoot++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough experience!");
                    }
                }
            }
            else
            {
                if (main.pete.approximationShoot < 4)
                {
                    if (main.pete.experience >= priceBetterAccuracyPlayer2)
                    {
                        main.pete.experience -= priceBetterAccuracyPlayer2;
                        priceBetterAccuracyPlayer2 += 40;
                        buttonBuyBetterAccPlayer2.Text = priceBetterAccuracyPlayer2.ToString();
                        textBoxExperiencePlayer2.Text = main.pete.experience.ToString();
                        main.pete.approximationShoot++;
                    }
                    else
                    {
                        MessageBox.Show("Not enough experience!");
                    }
                }
            }
        }
        /// <summary>
        /// Start another round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGame_Click(object sender, EventArgs e)
        {
            if (isFirstGame == false)
            {
                openGame = new Game(this, main);
                openGame.Show();
                isFirstGame = true;
                this.Visible = false;
            }
            else
            {
                openGame.Visible = true;
                this.Visible = false;
            }
        }
        /// <summary>
        /// Close game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
