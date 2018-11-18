using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace nqueens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsGame gg;
        int moveCount;
        int r;
        private void gameStart(int r)
        {
            MenuHint.Checked = false;
            if (gg != null)
                gg.RemoveForm(this);
            gg = new clsGame(MenuHint, r,this);
            for (int i = 0; i < gg.Btns.Count; i++)
                gg.Btns[i].MouseDown += new MouseEventHandler(btn_MouseDown);
            gg.isStarted = false;
            gg.AppendForm(this);
            lblStep.Text = "Step: " + gg.Step.ToString();
            MenuUndo.Enabled = false;
            MenuSave.Enabled = false;
            MenuReload.Enabled = true;
            MenuHint.Enabled = true;
            moveCount = 0;
        }
        private void Menu4_Click(object sender, EventArgs e)
        {
            r = 4;
            gameStart(r);
        }
        private void Menu6_Click(object sender, EventArgs e)
        {
            r = 6;
            gameStart(r);
        }
        private void Menu8_Click(object sender, EventArgs e)
        {
            r = 8;
            gameStart(r);
        }
        private void MenuUndo_Click(object sender, EventArgs e)
        {
            if (gg != null)
            {
                List<Button> d = gg.Done;
                if (d.Count > 0)
                {
                    gg.InitQueen(d.Last());
                    d.RemoveAt(d.Count - 1);
                    gg.Done = d;
                }
                gg.Step++;
                moveCount--;
            }
            lblStep.Text = "Step: " + gg.Step.ToString();
            gg.isSuccess();
            gg.menuInit(moveCount, MenuUndo, MenuSave);
            gg.Fresh();
        }
        private void MenuSave_Click(object sender, EventArgs e)
        {
            clsFile f = new clsFile(gg);
            f.saveData("game data\\queens of " + gg.Step.ToString() + ".txt");
        }
        private void MenuReload_Click(object sender, EventArgs e)
        {
            clsFile f = new clsFile(gg);
            f.loadData("game data\\queens of " + gg.Step.ToString() + ".txt");
        }

        private void MenuHint_Click(object sender, EventArgs e)
        {
            if (MenuHint.Checked)
                MenuHint.Checked = false;
            else
                MenuHint.Checked = true;
            gg.Item = MenuHint;
            gg.Fresh();
        }
        public void btn_MouseDown(object sender, MouseEventArgs e)
        {
            gg.isStarted = true;
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (b.Text == "O")
                {
                    gg.SetQueen(b);
                    if (!gg.isIn(gg.Done, b))
                        gg.Done.Add(b);
                    gg.Step--;
                    moveCount++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (b.Text == "queen")
                {
                    gg.InitQueen(b);
                    if (gg.Done != null)
                        gg.Done.Remove(b);
                    gg.Step++;
                    moveCount--;
                }
            }
            gg.Fresh();
            lblStep.Text = "Step: " + gg.Step.ToString();
            gg.isSuccess();
            gg.menuInit(moveCount, MenuUndo, MenuSave);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gg != null)
                    if (gg.isStarted)
                    {
                        DialogResult dr = MessageBox.Show("如果离开将丢失游戏进度，是否确认离开？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (dr == DialogResult.Cancel)
                            e.Cancel = true;
                        else
                            e.Cancel = false;
                    }
        }

        //private void Form1_SizeChanged(object sender, EventArgs e)
        //{
        //    gg.changeSize(this);
        //    this.Text = (this.Height > this.Width ? (this.Width > 300 ? this.Width : 300) : (this.Height > 300 ? this.Height : 300)).ToString();
        //}

        private void Form1_Resize(object sender, EventArgs e)
        {
            gg.changeSize(this);
            this.Text = (this.Height > this.Width ? (this.Width > 300 ? this.Width : 300) : (this.Height > 300 ? this.Height : 300)).ToString();
        }
    }
}
