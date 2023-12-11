using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        DateTime startDateTime;
        public Form1()
        {
            startDateTime = DateTime.Now;
            InitializeComponent();
        }
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
