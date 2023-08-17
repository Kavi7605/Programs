using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        string[] Names = { "abc", "kbc","eggse", "ageebc", "afefbce", "afefbc", "afefac", "adadbc", "abcvf", };

        private void button1_Click(object sender, EventArgs e)
        {
            int indexNames = rand.Next(Names.Length);
            this.textBox1.Text = Names[indexNames];
        }
    }
}
