using System;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace Csharp_project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kimchiSoup = { "김치", "돼지고기", "참기름", "양파", "청고추", "대파" };
            string[] kimchiPancake = { "김치", "부침가루", "식용유" };
            var kimchiSoup1 = kimchiSoup.ToList();
            var kimchiPancake1 = kimchiPancake.ToList();
            bool Soupflag = false;
            bool Pancakeflag = false;

            listView2.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string selecteditem = checkedListBox1.CheckedItems[i].ToString();
                if (kimchiSoup1.Contains(selecteditem))
                {
                    kimchiSoup1.Remove(selecteditem);
                }
                if (kimchiPancake1.Contains(selecteditem))
                {
                    kimchiPancake1.Remove(selecteditem);
                }
            }
            if (kimchiSoup1.Count == 0)
            {
                Soupflag = true;
            }
            if (kimchiPancake1.Count == 0)
            {
                Pancakeflag = true;
            }
            if (Soupflag)
            {
                listView2.Items.Add("김치찌개");
            }
            if (Pancakeflag)
            {
                listView2.Items.Add("김치전");
            }
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 배경색변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void 폰트변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
            this.ForeColor = fontDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "Please put keywords")
            {
                checkedListBox1.Items.Add(textBox1.Text);
                textBox1.Text = ""; 
            }
            else
            {
                textBox1.Text = "Please put keywords";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                while (checkedListBox1.Items.Count > 0)
                {
                    checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("please select the grediant that you want");
            }
        }

        private void Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems[0].Text =="김치전")
            {
                label1.Text = "김치전";
                textBox2.Text = "1. 오목한 그릇에 밀가루나 부침가루를 풀고 물을 붓는다.\r\n2. 김치를 썬 뒤 그릇에 넣고 섞은 다음 소금이나 김치국물로 간을 맞춰준다.\r\n3. 나무 도마일 경우, 김치를 손질할 때 도마에 김칫국물이 스며들면 빼내기 힘들기 때문에 김치전 반죽을 할 그릇에 김치를 담고 가위로 적당히 잘라내 주자.\r\n4. 식용유를 두른 팬에 부친다.";
                pictureBox1.Image = imageList1.Images[0];
            }
            if (listView2.SelectedItems[0].Text == "김치찌개")
            {
                label1.Text = "김치찌개";
                textBox2.Text = "1. 대파를 어슷썰기하고, 두부를 가로로 반으로 자르고 다시 세로로 1.5~2cm로 자른다.\r\n2. 식용유를 넣고, 돼지고기도 냄비에 넣는다. 맛술과 김치를 잘라 타지 않게 볶는다. \r\n3. 바닥에 돼지고기가 눌어붙기 시작한다면 중불로 줄여 물을 붓고 눌어붙은 것을 긁어낸다. 그 다음 맛술을 넣고 적당히 볶다가 물이 다 사라지고 붉은 기름만 남는다면 김치를 가위로 잘라 넣고 다시 오랫동안 타지않게 불 조절을 하며 볶는다.\r\n4. 김치볶음을 만든다고 생각하며 오래 볶은 다음, 두부와 대파를 넣고 물을 재료를 다 덮을 만큼 넣고, 고운 고춧가루 한 숟가락을 넣고 강불로 끓이다가 물이 끓으면 중약불로 낮추어 졸인다.\r\n5. 졸인 다음 김치찌개가 싱겁다면 소금을 넣어 간을 맞춘다.";
                pictureBox1.Image = imageList1.Images[1];
            }
        }
    }
}
