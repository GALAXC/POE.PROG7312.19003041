namespace POE.PROG7312._19003041
{
    partial class ReplaceBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooks));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsBar = new System.Windows.Forms.ToolStripMenuItem();
            this.correct20PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incorrect5PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upCallBtn = new System.Windows.Forms.Button();
            this.downCallBtn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.callNumBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pointsBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.GoBackToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // pointsBar
            // 
            this.pointsBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pointsBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correct20PointsToolStripMenuItem,
            this.incorrect5PointsToolStripMenuItem});
            this.pointsBar.Name = "pointsBar";
            this.pointsBar.Size = new System.Drawing.Size(76, 20);
            this.pointsBar.Text = "Points: 599";
            // 
            // correct20PointsToolStripMenuItem
            // 
            this.correct20PointsToolStripMenuItem.Enabled = false;
            this.correct20PointsToolStripMenuItem.Name = "correct20PointsToolStripMenuItem";
            this.correct20PointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.correct20PointsToolStripMenuItem.Text = "Correct: +20 points";
            // 
            // incorrect5PointsToolStripMenuItem
            // 
            this.incorrect5PointsToolStripMenuItem.Enabled = false;
            this.incorrect5PointsToolStripMenuItem.Name = "incorrect5PointsToolStripMenuItem";
            this.incorrect5PointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incorrect5PointsToolStripMenuItem.Text = "Incorrect: -5 points";
            // 
            // upCallBtn
            // 
            this.upCallBtn.Location = new System.Drawing.Point(255, 59);
            this.upCallBtn.Name = "upCallBtn";
            this.upCallBtn.Size = new System.Drawing.Size(75, 39);
            this.upCallBtn.TabIndex = 4;
            this.upCallBtn.Text = "Move Up";
            this.upCallBtn.UseVisualStyleBackColor = true;
            this.upCallBtn.Click += new System.EventHandler(this.UpCallBtn_Click);
            // 
            // downCallBtn
            // 
            this.downCallBtn.Location = new System.Drawing.Point(255, 104);
            this.downCallBtn.Name = "downCallBtn";
            this.downCallBtn.Size = new System.Drawing.Size(75, 37);
            this.downCallBtn.TabIndex = 5;
            this.downCallBtn.Text = "Move Down";
            this.downCallBtn.UseVisualStyleBackColor = true;
            this.downCallBtn.Click += new System.EventHandler(this.DownCallBtn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(255, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 58);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // callNumBox
            // 
            this.callNumBox.AllowDrop = true;
            this.callNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callNumBox.FormattingEnabled = true;
            this.callNumBox.IntegralHeight = false;
            this.callNumBox.ItemHeight = 24;
            this.callNumBox.Items.AddRange(new object[] {
            "My",
            "Name",
            "is",
            "Giovanni",
            "Giorgio",
            "but",
            "Everybody",
            "calls",
            "me",
            "",
            "Giorgio"});
            this.callNumBox.Location = new System.Drawing.Point(12, 30);
            this.callNumBox.Name = "callNumBox";
            this.callNumBox.Size = new System.Drawing.Size(234, 388);
            this.callNumBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort the call numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Remember to sort digit by digit, not as whole numbers";
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.downCallBtn);
            this.Controls.Add(this.upCallBtn);
            this.Controls.Add(this.callNumBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 524);
            this.MinimumSize = new System.Drawing.Size(355, 524);
            this.Name = "ReplaceBooks";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Training - Replace Books";
            this.Load += new System.EventHandler(this.ReplaceBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsBar;
        private System.Windows.Forms.Button upCallBtn;
        private System.Windows.Forms.Button downCallBtn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListBox callNumBox;
        private System.Windows.Forms.ToolStripMenuItem correct20PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorrect5PointsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}