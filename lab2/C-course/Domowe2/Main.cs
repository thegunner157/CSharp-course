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
    public partial class Main : Form
    {
        /// <summary>
        /// I carry selected character
        /// </summary>
        private Character character;
        /// <summary>
        /// Remember if I selected person
        /// </summary>
        bool isSelectedPlayer = false;
        /// <summary>
        /// Objects
        /// </summary>
        public Dave dave = new Dave();
        public Pete pete = new Pete();
        public Main()
        {
            InitializeComponent();
            comboBoxSelectCharacter.Items.Add(dave);
            
            comboBoxSelectCharacter.Items.Add(pete);
         

        }
        /// <summary>
        /// Start game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            ///After clicking button open new Form and set some properties.
            if (isSelectedPlayer)
            {
                Shop openShop = new Shop(this);
                openShop.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Select players first!");
            }
        }

        private void ComboBoxSelectCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            character = (Character)comboBoxSelectCharacter.SelectedItem;
        }

        /// <summary>
        /// Functions which create people
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNamePlayer1_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectCharacter.SelectedIndex != -1)
            { 
                if (character.getName() == "Dave")
                {
                    dave.whichPlayer = 1;
                    pete.whichPlayer = 2;
                    buttonNamePlayer1.Text = "Dave";
                    buttonNamePlayer2.Text = "Pete";
                    pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/dave.jpg");
                    pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/peteMain.png");
                    isSelectedPlayer = true;
                }
                else
                {
                    dave.whichPlayer = 2;
                    pete.whichPlayer = 1;
                    buttonNamePlayer2.Text = "Dave";
                    buttonNamePlayer1.Text = "Pete";
                    pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/dave.jpg");
                    pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/peteMain.png");
                    isSelectedPlayer = true;
                }
            }
            else
            {
                MessageBox.Show("You have selected noone!");
            }
        }

        private void ButtonNamePlayer2_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectCharacter.SelectedIndex != -1)
            {
                
                if (character.getName() == "Dave")
                {
                    dave.whichPlayer = 2;
                    pete.whichPlayer = 1;
                    buttonNamePlayer2.Text = "Dave";
                    buttonNamePlayer1.Text = "Pete";
                    pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/dave.jpg");
                    pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/peteMain.png");
                    isSelectedPlayer = true;
                }
                else
                {
                    dave.whichPlayer = 1;
                    pete.whichPlayer = 2;
                    buttonNamePlayer1.Text = "Dave";
                    buttonNamePlayer2.Text = "Pete";
                    pictureBoxPlayer1.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/dave.jpg");
                    pictureBoxPlayer2.Image = Image.FromFile("C:/C#kredek/karol_stula/lab2/Domowe2/Domowe2/peteMain.png");
                    isSelectedPlayer = true;
                }
            }
            else
            {
                MessageBox.Show("You have picked noone");
            }
        }
    }
}
