using System;
using System.Windows.Forms;

namespace Csharp_project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnubackcolor(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void mnubottoncolor(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            completebutton.BackColor = colorDialog1.Color;
            closebutton.BackColor = colorDialog1.Color;
            savebutton.BackColor= colorDialog1.Color;
        }

        private void completebutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontchange(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.ForeColor = fontDialog1.Color;
            textBox1.Font = fontDialog1.Font;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                description.Text = "텍스트를 입력하셔야 합니다.";

            }
            else
            {
                textBox2.Text += textBox3.Text + " " + textBox1.Text + "\r\n";
                textBox1.Text = "";
                textBox3.Text = "";
                description.Text = "해당 날짜에 무슨 일을 \n 하는지 입력합니다.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void ctmnu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newopen(object sender, EventArgs e)
        {
        }
    }
}
