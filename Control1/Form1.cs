using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Control1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string strTemp;
        private void UpdateLabel(string s, bool b)
        {
            if (b)
            {
                label3.Text += s;
            }
            else
            {
                strTemp = label3.Text; int i = strTemp.IndexOf(s.Substring(0, 1));
                int j = i + s.Length; label3.Text = strTemp.Remove(i, j - i);
            }
        }
        private void checkbox1_CheckedChange(object sender,
            EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }
        private void checkbox2_CheckedChange(object sender,
            EventArgs e)
        {
            UpdateLabel
            (checkBox2.Text, checkBox2.Checked);
        }
        private void checkbox3_CheckedChange(object sender,
            EventArgs e)
        {
            UpdateLabel
            (checkBox3.Text, checkBox3.Checked);
        }
        private void checkbox4_CheckedChange(object sender,
                EventArgs e)
        {
            UpdateLabel
            (checkBox4.Text, checkBox4.Checked);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender,
EventArgs e)
        {
            label2.Text = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender,
        EventArgs e)
        {
            label2.Text = radioButton2.Text;
        }
        private void radioButton3_CheckedChanged(object sender,
        EventArgs e)
        {
            label2.Text = radioButton3.Text;
        }
        private void radioButton4_CheckedChanged(object sender,
        EventArgs e)
        {
            label2.Text = radioButton4.Text;
        }

        private void linkLabel1_LinkClicked(object sender,
LinkLabelLinkClickedEventArgs e)
        {
            Process.Start
            (linkLabel1.Text);
        }
        private void linkLabel2_LinkClicked(object sender,
        LinkLabelLinkClickedEventArgs e)
        {
            Process.Start
            (linkLabel2.Text);
        }
        private void linkLabel3_LinkClicked(object sender,
    LinkLabelLinkClickedEventArgs e)
        {
            Process.Start
(linkLabel3.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender,
EventArgs e)
        {
            textBox3.Text = "Name: " + textBox1.Text + "\r\nPassword : " + textBox2.Text;
        }

        private void Button6_Click(object sender,
EventArgs e)
        {
            if (textBox4.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }
        private void Button7_Click(object sender,
        EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void button1_Click(object sender,
        EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
        private void button2_Click(object sender,
        EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}