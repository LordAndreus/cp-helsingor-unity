using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        int bingotal;
        bool[] trukkedeTal = new bool[91]; 

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bingotal = rnd.Next(1, 91);
            label1.Text = bingotal.ToString();
            var trukket = trukkedeTal[bingotal];
            if (trukket)
            {

                MessageBox.Show("Tallet er brugt");
            }
            trukkedeTal[bingotal] = true;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x < 11; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                var checkbox = new CheckBox();
                int tal = x + (y * 10);
                checkbox.Location = new Point(200 + x*50 , y * 50);
                checkbox.Text = tal.ToString();
                checkbox.Width = 45;
                this.Controls.Add(checkbox);
                    this.Update();
                }

                

            }
        }
    }
}
