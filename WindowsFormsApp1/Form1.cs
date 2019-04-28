using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool play = false;
        int counter = 0;
        bool klick = false;
        Timer czas = new Timer();
   
        Button b1;
        Button b2;
        string c1="";
        string c2 ="";
        int ile = 16;
        private void zmniejsz()
        {
            ile -= 2;
            if (ile == 0)
            {
                Form2 f = new Form2(label1.Text);
             
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.ReturnValue1 == "No")
                        Close();
                    if (f.ReturnValue1 == "Yes")
                    {

                        counter = 0;
                        label1.Text = counter.ToString() + " s";
                        Random rand = new Random();
                        int[] tab = new int[16];
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Button b = (Button)tableLayoutPanel1.GetControlFromPosition(i, j);
                                while (true)
                                {
                                    int r = rand.Next() % 8;
                                    if (tab[r] < 2)
                                    {
                                        b.Text = r.ToString();
                                        tab[r]++;
                                        b.Visible = true;
                                        break;
                                    }
                                }
                            }
                        }
                        czas = new Timer();
                        czas.Interval = 1000;
                        czas.Tick += aTimer;
                        ile = 16;
                        c1 = "";
                        c2 = "";
                        play = false;
                        button17.Text = "Play";
                    }
                }
            }
        }
        public Form1()
        {
           
            InitializeComponent();
            czas.Tick += aTimer;
            button4.BackColor = Color.AliceBlue;
            label1.Text = "0 s";
            counter = 0;
            button5.BackColor = Color.AliceBlue;
            button6.BackColor = Color.AliceBlue;
            button7.BackColor = Color.AliceBlue;
            button8.BackColor = Color.AliceBlue;
            button9.BackColor = Color.AliceBlue;
            button10.BackColor = Color.AliceBlue;
            button11.BackColor = Color.AliceBlue;
            button12.BackColor = Color.AliceBlue;
            button13.BackColor = Color.AliceBlue;
            button14.BackColor = Color.AliceBlue;
            button15.BackColor = Color.AliceBlue;
            button16.BackColor = Color.AliceBlue;
            button3.BackColor = Color.AliceBlue;
            ile = 16;
            counter = 0;
            play = false;
            label1.Text = counter.ToString() + " s";
            Random rand = new Random();
            int[] tab = new int[16];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button b = (Button)tableLayoutPanel1.GetControlFromPosition(i, j);
                    while (true)
                    {
                        int r = rand.Next() % 8;
                        if (tab[r] < 2)
                        {
                            b.Text = r.ToString();
                            tab[r]++;
                            break;
                        }
                    }
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            
           button1.BackColor = Color.Blue;
      

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.AliceBlue;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.AliceBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.AliceBlue;
        }

      

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.Blue;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.AliceBlue;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.Blue;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.AliceBlue;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.Blue;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.AliceBlue;
        }


        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Blue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.AliceBlue;
        }

      

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            button12.BackColor = Color.Blue;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.AliceBlue;
        }

 

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            button11.BackColor = Color.Blue;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.AliceBlue;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.Blue;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.AliceBlue;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.Blue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.AliceBlue;
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.BackColor = Color.Blue;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.AliceBlue;
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            button15.BackColor = Color.Blue;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.AliceBlue;
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            button14.BackColor = Color.Blue;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.AliceBlue;
        }

   

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            button13.BackColor = Color.Blue;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.AliceBlue;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            czas.Interval = 1000;

            if (button17.Text == "Play")
            {

                play = true;
                czas.Start();

                button17.Text = "Pause";
            }
            else
            {
                czas.Stop();
                button17.Text = "Play";

                play = false;
            }


        }
        private void aTimer(object sender, EventArgs e)
        {   if (play)
            {
                counter++;
                label1.Text = counter.ToString() + " s";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            counter = 0;
            label1.Text = counter.ToString() + " s";
            Random rand = new Random();
            int[] tab =new int[16];
            for (int i = 0; i < 4; i++)
            { for (int j = 0; j < 4; j++)
                {
                    Button b = (Button)tableLayoutPanel1.GetControlFromPosition(i, j);
                    while(true)
                    {
                        int r = rand.Next() % 8;
                        if(tab[r]<2)
                        {
                            b.Text = r.ToString();
                            tab[r]++;
                            b.Visible = true;
                            break;
                        }
                    }
                }
            }
            czas = new Timer();
            czas.Interval = 1000;
            czas.Tick += aTimer;
            ile = 16;
            c1 = "";
            c2 = "";
            play = false;
            button17.Text = "Play";



        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Blue;
        }
        
        private void button12_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (play)
            {
                b.BackColor = Color.IndianRed;
                if (c1 == "")
                {
                    b1 = b;
                    c1 = b.Text;

                }
                else if (c2 == "")
                {
                    b2 = b;
                    c2 = b.Text;
                    if (c2 == c1)
                    {
                        b1.Visible = false;
                        b2.Visible = false; zmniejsz();
                    }
                    c1 = "";
                    c2 = "";
                }
            }
        }
    }
}
