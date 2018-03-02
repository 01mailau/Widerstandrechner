using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wiederstände
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
            rechnung();
            ringe();


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem.ToString();
            rechnung();
            ringe1();



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechnung();
            ringe2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ringe()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string schwarz =" 0";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string braun = "1";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                string rot = "2";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                string orange = "3";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                string gelb = "4";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                string grün  = "5";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                string blau = "6";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                string violett = "7";
            }
            if (comboBox1.SelectedIndex == 8)
            {
                string grau = "8";
            }
            if (comboBox1.SelectedIndex == 9)
            {
                string weiß= "9";
            }

        }

           private void ringe1()
           {

            if (comboBox2.SelectedIndex == 0)
            {
                string schwarz = "0";
            }

            if (comboBox2.SelectedIndex == 1)
            {
                string braun = "1";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                string rot = "2";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                string orange = "3";
            }
            if (comboBox2.SelectedIndex == 4)
            {
                string gelb = "4";
            }
            if (comboBox2.SelectedIndex == 5)
            {
                string grün = "5";
            }
            if (comboBox2.SelectedIndex == 6)
            {
                string blau = "6";
            }
            if (comboBox2.SelectedIndex == 7)
            {
                string violett = "7";
            }
            if (comboBox2.SelectedIndex == 8)
            {
                string grau = "8";
            }
            if (comboBox2.SelectedIndex == 9)
            {
                string weiß = "9";
            }

        }

           private void ringe2()
           {

               if (comboBox3.SelectedIndex == 0)
               {
                   int schwarz = 0;
               }

               if (comboBox3.SelectedIndex == 1)
               {
                   int braun = 1;
               }
               if (comboBox3.SelectedIndex == 2)
               {
                   int rot = 2;
               }
               if (comboBox3.SelectedIndex == 3)
               {
                   int orange = 3;
               }
               if (comboBox3.SelectedIndex == 4)
               {
                   int gelb = 4;

                   if (comboBox3.SelectedIndex == 5)
                   {
                       int grün = 5;
                   }
                   if (comboBox3.SelectedIndex == 6)
                   {
                       int blau = 6;
                   }
                   if (comboBox3.SelectedIndex == 7)
                   {
                       int violett = 7;
                   }
                   if (comboBox3.SelectedIndex == 8)
                   {
                       int grau = 8;
                   }
                   if (comboBox3.SelectedIndex == 9)
                   {
                       int weiß = 9;
                   }

               }
           }
           private void ringe3()
           {

               if (comboBox3.SelectedIndex == 0)
               {
                   int silber= 10;
               }

               if (comboBox3.SelectedIndex == 1)
               {
                   int gold = 5;
               }
               if (comboBox3.SelectedIndex == 2)
               {
                   int rot = 1;
               }
               if (comboBox3.SelectedIndex == 3)
               {
                   int braun = 2;
               }
               
           }
        private void rechnung()
        {
 
        }

        private void Ausgeben_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedIndex.ToString();
            textBox1.Text += comboBox2.SelectedIndex.ToString();
            textBox1.Text += comboBox3.SelectedIndex.ToString();
        
        }
    }
}
