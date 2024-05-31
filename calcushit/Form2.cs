using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcushit
{
    public partial class Form2 : Form
    {


        private int operation;
        Control ActiveControl;
        public Form2()
        {
            InitializeComponent();
            operation = 0;
        }

        // window drop shadow 
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(button.Text);
        }

        private void textEnter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(button.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonEnable();
            button13.Enabled = false;
            operation = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonEnable();
            button14.Enabled = false;
            operation = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonEnable();
            button15.Enabled = false;
            operation = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonEnable();
            button16.Enabled = false;
            operation = 4;
        }

        private void buttonEnable()
        {
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
                    textBox3.Text = result.ToString();
                    break;
                case 2:
                    result = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
                    textBox3.Text = result.ToString();
                    break;
                case 3:
                    result =Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                    textBox3.Text = result.ToString();
                    break;
                case 4:
                    result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                    textBox3.Text = result.ToString();
                    break;
                default: break;
            }
        }
    }
}
