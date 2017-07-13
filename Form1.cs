using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window2
{
    public partial class Form1 : Form
    {
        //     int number;
        // static   int counter = 0;
        //    int mainNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int number;
        int counter = 0;
        int mainNum;

        private void button1_Click(object sender, EventArgs e)
        {            
            Random random = new Random();
            int mainNum = random.Next(10);

            if (counter < 3)
            {
                try
                {
                    number = int.Parse(Text.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Text.Clear();
                    counter++;
                    return;
                }
                if (number == mainNum)
                {
                    MessageBox.Show("Hurray!! you won a car");
                    var show = MessageBox.Show("Do u want to play again?", "prompt", MessageBoxButtons.YesNo);
                    if (show == DialogResult.Yes)
                    {

                        return;

                    }
                    else
                    {
                    Application.Exit();
                }
                   // Application.Exit();
                }
                else if (number != mainNum)
                {
                    MessageBox.Show("incorrect, Try again");
                    Text.Clear();
                }
                counter++;
            }
            else
            {
                MessageBox.Show("You have exceeded the number of tries");
               
                    Application.Exit();
                }
                // Application.Exit();
            }
        }
    }
   
