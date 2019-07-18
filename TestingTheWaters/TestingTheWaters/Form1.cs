using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingTheWaters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Console.WriteLine(@"These are not the droids you are looking for");
            Console.WriteLine(@"I am very sleepy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("I have the high ground");
        }
    }
}
