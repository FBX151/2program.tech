using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class Form1 : Form
    {
        Button [] btns = new Button[15];
        public Form1()
        {
           
            InitializeComponent();
            btns[0] = button1;
            btns[1] = button2;

            btns[2] = button3;
            btns[3] = button4;

            btns[4] = button5;
            btns[5] = button6;
            btns[6] = button7;
            btns[7] = button8;
            btns[8] = button9;
            btns[9] = button10;
            btns[10] = button11;
            btns[11] = button12;
            btns[12] = button13;
            btns[13] = button14;
            btns[14] = button15;
            
            foreach(Button b in btns)
            {
                b.BackColor = Color.Gray;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach( Button b in btns)
            {
                if(b.BackColor == Color.Red)
                {
                    b.BackColor = Color.Gray;
                }
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            foreach(Button b in btns)
            {
                if (Math.Abs(int.Parse(btn.Text) - int.Parse(b.Text)) % 10 == 0 || Math.Abs((int.Parse(btn.Text) - int.Parse(b.Text)) < 5){

                }


                    b.BackColor = Color.Red;
                }
            }
        }
    }
}
