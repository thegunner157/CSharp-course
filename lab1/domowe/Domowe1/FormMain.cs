using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domowe1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //utworzenie obiektu nowego okienka
            FormGame game;
            //przypisanie wartosci nowego obiektu
            game = new FormGame();
            //Wyswietl nowe okno
            game.Show();
            
        }
    }
}
