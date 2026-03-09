using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vezetéknév: " + textBox1.Text + " \n" +
                            "Keresztnév: " + textBox1.Text + " \n" +
                            "E-mail: " + textBox1.Text + " \n" +
                            "Kor: " + textBox1.Text + " \n" +
                            "Férfi: " + radioButton1.Checked + " \n" +
                            "Nő: " + radioButton2.Checked + " \n" +
                            "Értesíts: " + checkBox1.Checked + " \n");
        }
    }
}
