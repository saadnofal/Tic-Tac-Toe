using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {

        bool check;

        int count = 0;
        playerWin X = new playerWin(0);
        playerWin O = new playerWin(0);
        playerDraw D = new playerDraw(0);
        public void Enable_false() // انتهاء الدور
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public void back() //     ميثود الاعادة1  تفضاية النص وتغير ون الخلفية
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
        public void back2()// اعادة الدور 2 مشان يشتغل الزر
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }
        public void colorX()
        {
            check = false;
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;

            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;

            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;

            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;

            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;

            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;

            }
            check = true;
        }// x win color
        public void colorO()
        {
            check = true;
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                button1.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                button1.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                button2.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;

            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                button3.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                button3.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;

            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                button4.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;

            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

            }
            check = false;
        }// o win color

        public void Game()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text == "X" ||
           button1.Text == button4.Text && button1.Text == button7.Text && button1.Text == "X" ||
           button1.Text == button5.Text && button1.Text == button9.Text && button1.Text == "X" ||
           button2.Text == button5.Text && button2.Text == button8.Text && button2.Text == "X" ||
           button3.Text == button6.Text && button3.Text == button9.Text && button3.Text == "X" ||
           button3.Text == button5.Text && button3.Text == button7.Text && button3.Text == "X" ||
           button4.Text == button5.Text && button4.Text == button6.Text && button4.Text == "X" ||
           button7.Text == button8.Text && button7.Text == button9.Text && button7.Text == "X")
            {
                colorX();
                X.Score += 1;
                plx.Text = X.Score.ToString();
                MessageBox.Show("player X won");
                Enable_false();

            }
            else if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text == "O" ||
       button1.Text == button4.Text && button1.Text == button7.Text && button1.Text == "O" ||
       button1.Text == button5.Text && button1.Text == button9.Text && button1.Text == "O" ||
       button2.Text == button5.Text && button2.Text == button8.Text && button2.Text == "O" ||
       button3.Text == button5.Text && button3.Text == button7.Text && button3.Text == "O" ||
       button3.Text == button6.Text && button3.Text == button9.Text && button3.Text == "O" ||
       button4.Text == button5.Text && button4.Text == button6.Text && button4.Text == "O" ||
       button7.Text == button8.Text && button7.Text == button9.Text && button7.Text == "O")
            {
                colorO();
                O.Score += 1;
                plo.Text = O.Score.ToString();
                MessageBox.Show("player O won");
                Enable_false();
            }
            else if (count == 9)//draw
            {
                MessageBox.Show("it is a draw");
                D.Score += 1;
                lbld.Text = D.Score.ToString();
                count = 0;
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            


            if (check == false)
            {
                button1.Text = "X";
                check = true;
            }
            else
            {
                button1.Text = "O";
                check = false;
            }
            button1.Enabled = false;
            count++;
            Game();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button2.Text = "X";
                check = true;
            }
            else
            {
                button2.Text = "O";
                check = false;
            }
            button2.Enabled = false;
            count++;
            Game();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button3.Text = "X";
                check = true;
            }
            else
            {
                button3.Text = "O";
                check = false;
            }
            button3.Enabled = false;
            count++;
            Game();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            button4.Enabled = false;
            count++;
            Game();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            button5.Enabled = false;
            count++;
            Game();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            button6.Enabled = false;
            count++;
            Game();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            button7.Enabled = false;
            count++;
            Game();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            button8.Enabled = false;
            count++;
            Game();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            button9.Enabled = false;
            count++;
            Game();

        }

        private void reset_Click(object sender, EventArgs e) // New round
        {
            count = 0;
            back();
            back2();
        }

        

        private void exit_Click(object sender, EventArgs e) // Exit
        {
            Application.Exit();
        }

        

        private void newgame_Click_1(object sender, EventArgs e)//new game
        {
            check = false;
            plx.Text = Convert.ToString(0);
            plo.Text = Convert.ToString(0);
            lbld.Text = Convert.ToString(0);
            count = 0;
            back();
            back2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}




