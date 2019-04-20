using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolStulaLab2
{
    public partial class Form1 : Form
    {
        //przechowuje wybrany kształt z listy
        private Shape shape;
        public Form1()
        {
            InitializeComponent();
            Circle circle = new Circle();
            Square square = new Square();
            comboBoxShape.Items.Add(square);
            comboBoxShape.Items.Add(circle);
        }
        /// <summary>
        /// reakcja na zmiane kształtu wybranego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = (Shape)comboBoxShape.SelectedItem;
        }
        /// <summary>
        /// reakcja na przycisk do obliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonArea_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex!=-1)
            {
                textBoxArea.Text = shape.Area().ToString();
            }
            else
            {
                MessageBox.Show("Nie wybrales nic");
            }
        }
        /// <summary>
        /// obsluga zmiany rozmiaru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSize_Click(object sender, EventArgs e)
        {
            if(shape is IReseizable)
            {
                IReseizable reseizable = (IReseizable)shape;
                reseizable.ChangeSize();
            }
            else
            {
                MessageBox.Show("Nie da się zmienić rozmiaru tego kształtu");
            }
        }

        private void ButtonPerimeter_Click(object sender, EventArgs e)
        {
            textBoxPerimeter.Text = shape.Perimeter();

        }
    }
}
