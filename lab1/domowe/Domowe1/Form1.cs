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
    public partial class FormGame : Form
    {
        //Zmienna co ile katastrofa
        int HowLongToCat = 30;
        //Tworzenie counter
        int counter;
        //Tworzenie ilosci drewna, golda, food
        int HowManyFood;
        int HowManyWood;
        int HowManyGold;
        //Czy kupil upgrade na wood i food
        int UpgradeWood;
        int UpgradeFood;
        //Baza ile dodac
        int Baza = 2;
        public FormGame()
        {
            InitializeComponent();
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            //zwieksz counter
            counter++;
            //pokaz timer na textBox'ie
            textBoxNumber.Text = counter.ToString();
            //Co 1 sek Gold +1
            HowManyGold++;
            textBoxHowManyGold.Text = HowManyGold.ToString();
            //Co 3 sek Food +5, chyba że upgrade kupiony
            if (counter % 3 == 0) { 
                HowManyFood = HowManyFood+5+Baza*UpgradeFood;
                textBoxHowManyFood.Text = HowManyFood.ToString();
            }
            //Co 5 sek Wood +5, chyba że upgrade kupiony
            if (counter % 5 == 0){ 
                HowManyWood = HowManyWood+5+Baza* UpgradeWood;
                textBoxHowManyWood.Text = HowManyWood.ToString();
            }
            //Katastrofa co 30 sekund
            if (counter%HowLongToCat==0)
            {
                //Kazda katastrofa coraz szybciej 
                if (HowLongToCat >= 10)
                {
                    HowLongToCat--;
                }
                HowManyFood -= 30;
                HowManyWood -= 30;
                textBoxHowManyWood.Text = HowManyWood.ToString();
                textBoxHowManyWood.Text = HowManyWood.ToString();
                if (HowManyFood<0 || HowManyWood < 0)
                {
                    //utworzenie obiektu nowego okienka
                    FormEnd end;
                    //przypisanie wartosci nowego obiektu
                    end = new FormEnd();
                    //Wyswietl nowe okno
                    end.Show();
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //start timera
            timerGame.Start();
            
        }

        private void ButtonBuyFood_Click(object sender, EventArgs e)
        {
            //kup food
            if(HowManyGold>=20)
            {
                HowManyGold -= 20;
                UpgradeFood +=1;
            }
        }

        private void ButtonBuyWood_Click(object sender, EventArgs e)
        {
            //kup wood
            if (HowManyGold >= 25)
            {
                HowManyGold -= 25;
                UpgradeFood += 1;
            }
        }
    }
}
