using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dose
{
    public partial class Form1 : Form
    {
        int[,] Array = new int[3, 3];
        static int roundNumber = 0;
        int player1 = 1;
        int player2 = 2;

        int player1Score = 0;
        int player2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Array[0, 0] == 1 || Array[0, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 0] = player1;
                    button1.BackColor = Color.Yellow;
                }
                else
                {
                    Array[0, 0] = player2;
                    button1.BackColor = Color.Green;
                    
                }
                
                int z = Array[0, 0];
                finally1(z);
            }         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[0, 1] == 1 || Array[0, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 1] = player1;
                    button2.BackColor = Color.Yellow;
                }
                else
                {
                    Array[0, 1] = player2;
                    button2.BackColor = Color.Green;
                }
                
                int z = Array[0, 1];
                finally1(z);
            }              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Array[0, 2] == 1 || Array[0, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 2] = player1;
                    button3.BackColor = Color.Yellow;
                }
                else
                {
                    Array[0, 2] = player2;
                    button3.BackColor = Color.Green;
                }
                
                int z = Array[0, 2];
                finally1(z);
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Array[1, 0] == 1 || Array[1, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 0] = player1;
                    button4.BackColor = Color.Yellow;
                }
                else
                {
                    Array[1, 0] = player2;
                    button4.BackColor = Color.Green;
                }
                
                int z = Array[1, 0];
                finally1(z);
            }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Array[1, 1] == 1 || Array[1, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 1] = player1;
                    button5.BackColor = Color.Yellow;
                }
                else
                {
                    Array[1, 1] = player2;
                    button5.BackColor = Color.Green;
                }
                
                int z = Array[1, 1];
                finally1(z);
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Array[1, 2] == 1 || Array[1, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 2] = player1;
                    button6.BackColor = Color.Yellow;
                }
                else
                {
                    Array[1, 2] = player2;
                    button6.BackColor = Color.Green;
                }
                
                int z = Array[1, 2];
                finally1(z);
            }       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Array[2, 0] == 1 || Array[2, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 0] = player1;
                    button7.BackColor = Color.Yellow;
                }
                else
                {
                    Array[2, 0] = player2;
                    button7.BackColor = Color.Green;
                }
                
                int z = Array[2, 0];
                finally1(z);
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Array[2, 1] == 1 || Array[2, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 1] = player1;
                    button8.BackColor = Color.Yellow;
                }
                else
                {
                    Array[2, 1] = player2;
                    button8.BackColor = Color.Green;
                }
                
                int z = Array[2, 1];
                finally1(z);
            }     
        }

        private void button9_Click(object sender, EventArgs e)
        {
           if (Array[2, 2]==1 || Array[2, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 2] = player1;
                    button9.BackColor = Color.Yellow;
                }
                else
                {
                    Array[2, 2] = player2;
                    button9.BackColor = Color.Green;
                }
                
                int z = Array[2, 2];
                finally1(z);
            }      
        }

        private bool checkWinner(int player)
        {
            // check rows
            if (Array[0, 0] == player && Array[0, 1] == player && Array[0, 2] == player) { return true; }
            if (Array[1, 0] == player && Array[1, 1] == player && Array[1, 2] == player) { return true; }
            if (Array[2, 0] == player && Array[2, 1] == player && Array[2, 2] == player) { return true; }

            // check columns
            if (Array[0, 0] == player && Array[1, 0] == player && Array[2, 0] == player) { return true; }
            if (Array[0, 1] == player && Array[1, 1] == player && Array[2, 1] == player) { return true; }
            if (Array[0, 2] == player && Array[1, 2] == player && Array[2, 2] == player) { return true; }

            // check diags
            if (Array[0, 0] == player && Array[1, 1] == player && Array[2, 2] == player) { return true; }
            if (Array[0, 2] == player && Array[1, 1] == player && Array[2, 0] == player) { return true; }
            return false;
        }

        private void MessageBox_chechwinner(int a)
        {
            if (checkWinner(a))
            {
                if (a == 1)
                {
                    MessageBox.Show("Player 1 Wins !!");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins !!");
                }

            }
            else
            {
                if (roundNumber == 9)
                {
                    MessageBox.Show("Game Over");
                }
            }

        }


        private void reset()
        {
            button1.BackColor = Color.CadetBlue;
            button2.BackColor = Color.CadetBlue;
            button3.BackColor = Color.CadetBlue;
            button4.BackColor = Color.CadetBlue;
            button5.BackColor = Color.CadetBlue;
            button6.BackColor = Color.CadetBlue;
            button7.BackColor = Color.CadetBlue;
            button8.BackColor = Color.CadetBlue;
            button9.BackColor = Color.CadetBlue;

            for(int i=0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    Array[i, j] = 0;
                }
            }
            roundNumber = 0;   
        }

       

        private int finally1(int b)
        {
            MessageBox_chechwinner(b);

            if (checkWinner(b))
            {
                if (b == 1)
                {
                    player1Score++;
                }
                if (b == 2)
                {
                    player2Score++;
                }

                updateScoreTextbox();

                reset();
            }
            if (roundNumber == 9)
            {
                reset();
            }
            return 1;
        }

           private void label2_Click(object sender, EventArgs e)
           {

           }
        private void updateScoreTextbox()
        {
            textBox1.Text = player1Score.ToString();
            textBox2.Text = player2Score.ToString();
        }    
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            player1Score = 0;
            player2Score = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("به بازی دوز خوش آمدید", "پیام خوش آمدگویی", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا از برنامه خارج می شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("خروج از برنامه لغو شد", "لغو");
            }
        }
    }
}
