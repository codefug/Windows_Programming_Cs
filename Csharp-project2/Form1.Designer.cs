namespace Csharp_project2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.completebutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.닫기xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창열기 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버튼색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴변경AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 71);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            // 
            // completebutton
            // 
            this.completebutton.Location = new System.Drawing.Point(60, 290);
            this.completebutton.Name = "completebutton";
            this.completebutton.Size = new System.Drawing.Size(165, 35);
            this.completebutton.TabIndex = 2;
            this.completebutton.Text = "선택 완료";
            this.completebutton.UseVisualStyleBackColor = true;
            this.completebutton.Click += new System.EventHandler(this.completebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(646, 391);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(151, 35);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "닫기";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.닫기xToolStripMenuItem,
            this.새창열기});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 52);
            // 
            // 닫기xToolStripMenuItem
            // 
            this.닫기xToolStripMenuItem.Name = "닫기xToolStripMenuItem";
            this.닫기xToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.닫기xToolStripMenuItem.Text = "닫기(&x)";
            this.닫기xToolStripMenuItem.Click += new System.EventHandler(this.ctmnu_Click);
            // 
            // 새창열기
            // 
            this.새창열기.Name = "새창열기";
            this.새창열기.Size = new System.Drawing.Size(165, 24);
            this.새창열기.Text = "새 창 열기(&c)";
            this.새창열기.Click += new System.EventHandler(this.newopen);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배경색변경ToolStripMenuItem,
            this.버튼색변경ToolStripMenuItem,
            this.글꼴변경AToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.편집ToolStripMenuItem.Text = "편집(&E)";
            // 
            // 배경색변경ToolStripMenuItem
            // 
            this.배경색변경ToolStripMenuItem.Name = "배경색변경ToolStripMenuItem";
            this.배경색변경ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.배경색변경ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.배경색변경ToolStripMenuItem.Text = "배경색 변경(&B)";
            this.배경색변경ToolStripMenuItem.Click += new System.EventHandler(this.mnubackcolor);
            // 
            // 버튼색변경ToolStripMenuItem
            // 
            this.버튼색변경ToolStripMenuItem.Name = "버튼색변경ToolStripMenuItem";
            this.버튼색변경ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.버튼색변경ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.버튼색변경ToolStripMenuItem.Text = "버튼색 변경(&K)";
            this.버튼색변경ToolStripMenuItem.Click += new System.EventHandler(this.mnubottoncolor);
            // 
            // 글꼴변경AToolStripMenuItem
            // 
            this.글꼴변경AToolStripMenuItem.Name = "글꼴변경AToolStripMenuItem";
            this.글꼴변경AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.글꼴변경AToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.글꼴변경AToolStripMenuItem.Text = "글꼴 변경(&A)";
            this.글꼴변경AToolStripMenuItem.Click += new System.EventHandler(this.fontchange);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.보기ToolStripMenuItem.Text = "보기(&V)";
            this.보기ToolStripMenuItem.Click += new System.EventHandler(this.보기ToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "선택한 날짜를 출력합니다";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 107);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "일정을 저장합니다.";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(313, 277);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(151, 35);
            this.savebutton.TabIndex = 10;
            this.savebutton.Text = "저장";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(301, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 25);
            this.textBox3.TabIndex = 11;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(301, 205);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(162, 30);
            this.description.TabIndex = 12;
            this.description.Text = "해당 날짜에 무슨 일을 \n 하는지 입력합니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.description);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.completebutton);
            this.Controls.Add(this.monthCalendar1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button completebutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버튼색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴변경AToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.ToolStripMenuItem 닫기xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창열기;
    }
}

