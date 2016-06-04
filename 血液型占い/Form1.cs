using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("慎重");
            else if (radioButton2.Checked)
                MessageBox.Show("マイペース");
            else if (radioButton3.Checked)
                MessageBox.Show("おおらか");
            else if (radioButton4.Checked)
                MessageBox.Show("天才肌");
        }
    }
}
