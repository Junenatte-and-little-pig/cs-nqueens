namespace nqueens
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MS = new System.Windows.Forms.MenuStrip();
            this.MenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHint = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.MS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS
            // 
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStart});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(484, 25);
            this.MS.TabIndex = 0;
            this.MS.Text = "menuStrip1";
            // 
            // MenuStart
            // 
            this.MenuStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBoard,
            this.MenuUndo,
            this.MenuSave,
            this.MenuReload,
            this.MenuHint});
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(44, 21);
            this.MenuStart.Text = "开始";
            // 
            // MenuBoard
            // 
            this.MenuBoard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu4,
            this.Menu6,
            this.Menu8});
            this.MenuBoard.Name = "MenuBoard";
            this.MenuBoard.Size = new System.Drawing.Size(170, 22);
            this.MenuBoard.Text = "新棋盘";
            // 
            // Menu4
            // 
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(95, 22);
            this.Menu4.Text = "4*4";
            this.Menu4.Click += new System.EventHandler(this.Menu4_Click);
            // 
            // Menu6
            // 
            this.Menu6.Name = "Menu6";
            this.Menu6.Size = new System.Drawing.Size(95, 22);
            this.Menu6.Text = "6*6";
            this.Menu6.Click += new System.EventHandler(this.Menu6_Click);
            // 
            // Menu8
            // 
            this.Menu8.Name = "Menu8";
            this.Menu8.Size = new System.Drawing.Size(95, 22);
            this.Menu8.Text = "8*8";
            this.Menu8.Click += new System.EventHandler(this.Menu8_Click);
            // 
            // MenuUndo
            // 
            this.MenuUndo.Enabled = false;
            this.MenuUndo.Name = "MenuUndo";
            this.MenuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuUndo.Size = new System.Drawing.Size(170, 22);
            this.MenuUndo.Text = "撤销";
            this.MenuUndo.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Enabled = false;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(170, 22);
            this.MenuSave.Text = "保存";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuReload
            // 
            this.MenuReload.Enabled = false;
            this.MenuReload.Name = "MenuReload";
            this.MenuReload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuReload.Size = new System.Drawing.Size(170, 22);
            this.MenuReload.Text = "载入";
            this.MenuReload.Click += new System.EventHandler(this.MenuReload_Click);
            // 
            // MenuHint
            // 
            this.MenuHint.Enabled = false;
            this.MenuHint.Name = "MenuHint";
            this.MenuHint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MenuHint.Size = new System.Drawing.Size(170, 22);
            this.MenuHint.Text = "提示模式";
            this.MenuHint.Click += new System.EventHandler(this.MenuHint_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHint.Location = new System.Drawing.Point(0, 449);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(137, 12);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "左键选中，右键取消选中";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStep.Location = new System.Drawing.Point(0, 437);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(47, 12);
            this.lblStep.TabIndex = 2;
            this.lblStep.Text = "Steps: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.MS);
            this.MainMenuStrip = this.MS;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            //this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS;
        private new System.Windows.Forms.ToolStripMenuItem MenuStart;
        private System.Windows.Forms.ToolStripMenuItem MenuBoard;
        private System.Windows.Forms.ToolStripMenuItem Menu4;
        private System.Windows.Forms.ToolStripMenuItem Menu6;
        private System.Windows.Forms.ToolStripMenuItem Menu8;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ToolStripMenuItem MenuUndo;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuReload;
        private System.Windows.Forms.ToolStripMenuItem MenuHint;
    }
}

