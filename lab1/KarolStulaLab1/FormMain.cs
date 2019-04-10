using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolStulaLab1
{
    public partial class FormMain : Form
    {
        //suma do liczenia textboxa
        int counter;
        public FormMain()
        {
            InitializeComponent();
           
        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            ///Funkcja zamykająca okienko główne
            Close();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            //Zmiana koloru przycisku zamknij
            buttonClose.BackColor = Color.Orange;
            //Zmiana koloru tła
            BackColor = Color.Red;
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            //Zmien kolor czcionki przycisku zmien
            buttonChange.ForeColor = Color.Pink;
            //Zmien kolor tła labela
            labelName.BackColor = Color.Blue;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            //przypisanie nowej wartości
            int newNumber = Int32.Parse(textBoxNumber.Text);
            counter+=1;
            //zamien counter na text
            textBoxNumber.Text = counter.ToString();
            if (counter > 5)
                MessageBox.Show(counter.ToString());
        }

        private void TimerCounter_Tick(object sender, EventArgs e)
        {
            //zwiekszanie licznika
            counter++;
            //pokaz timer na textBox'ie
            textBoxNumber.Text = counter.ToString();
            if (counter == 5)
            {
                BackColor = Color.Aqua;
            }
            if (counter % 2 == 0)
            {
                buttonChange.Location = new Point(buttonChange.Location.X - 5, buttonChange.Location.Y - 5);
            }
            else
            {
                buttonChange.Location = new Point(buttonChange.Location.X+5 , buttonChange.Location.Y+5 );
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //start timera
            timerCounter.Start();
        }

        private void ButtonChangeObject_Click(object sender, EventArgs e)
        {
            //utworzenie obiektu nowego okienka
            FormAbout formAbout;
            //przypisanie wartosci nowego obiektu
            formAbout = new FormAbout();
            //Wyswietl nowe okno
            formAbout.Show();
        }
    }
}
