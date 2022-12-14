using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Operators
{
    public partial class Form1 : Form
    {
        bool ctrl = false, Q = false;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0X20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                ctrl = true;
            else if (e.KeyCode == Keys.Q)
                Q = true;
            //---------------
            if (ctrl && Q)
            {
                ctrl = false;
                Q = false;
                Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                ctrl = false;
            else if (e.KeyCode == Keys.Q)
                Q = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                CheckRButton(0);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                CheckRButton(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                CheckRButton(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                CheckRButton(3);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                CheckRButton(4);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                CheckRButton(5);
        }

        public void CheckRButton(byte ValueRB)
        {
            switch (ValueRB)
            {
                case 0:
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    break;
                case 1:
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    break;
                case 2:
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Blue;
                    break;
                case 3:
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Yellow;
                    break;
                case 4:
                    button1.BackColor = Color.Purple;
                    button2.BackColor = Color.Purple;
                    button3.BackColor = Color.Purple;
                    button4.BackColor = Color.Purple;
                    button5.BackColor = Color.Purple;
                    button6.BackColor = Color.Purple;
                    break;
                case 5:
                    button1.BackColor = Color.Orange;
                    button2.BackColor = Color.Orange;
                    button3.BackColor = Color.Orange;
                    button4.BackColor = Color.Orange;
                    button5.BackColor = Color.Orange;
                    button6.BackColor = Color.Orange;
                    break;
            }
        }
    }
}
