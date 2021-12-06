
namespace POE.PROG7312._19003041
{
    partial class FindingCallNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingCallNumbers));
            this.answerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsBar = new System.Windows.Forms.ToolStripMenuItem();
            this.correct20PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incorrect5PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.firstLevelList = new System.Windows.Forms.ListBox();
            this.secondLevelList = new System.Windows.Forms.ListBox();
            this.thirdLevelList = new System.Windows.Forms.ListBox();
            this.btnNextFirst = new System.Windows.Forms.Button();
            this.btnNextSecond = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(977, 245);
            this.answerLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Padding = new System.Windows.Forms.Padding(10);
            this.answerLabel.Size = new System.Drawing.Size(195, 95);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "Lorem Ipsum is dummy text used to fill  spaces";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pointsBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.correct20PointsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.correct20PointsToolStripMenuItem.Text = "Correct: +20 points";
            // 
            // incorrect5PointsToolStripMenuItem
            // 
            this.incorrect5PointsToolStripMenuItem.Enabled = false;
            this.incorrect5PointsToolStripMenuItem.Name = "incorrect5PointsToolStripMenuItem";
            this.incorrect5PointsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.incorrect5PointsToolStripMenuItem.Text = "Incorrect: -5 points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(936, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Goal is:";
            // 
            // firstLevelList
            // 
            this.firstLevelList.FormattingEnabled = true;
            this.firstLevelList.Location = new System.Drawing.Point(12, 168);
            this.firstLevelList.Name = "firstLevelList";
            this.firstLevelList.Size = new System.Drawing.Size(390, 199);
            this.firstLevelList.TabIndex = 5;
            // 
            // secondLevelList
            // 
            this.secondLevelList.BackColor = System.Drawing.SystemColors.Control;
            this.secondLevelList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.secondLevelList.FormattingEnabled = true;
            this.secondLevelList.Location = new System.Drawing.Point(408, 168);
            this.secondLevelList.Name = "secondLevelList";
            this.secondLevelList.Size = new System.Drawing.Size(390, 199);
            this.secondLevelList.TabIndex = 6;
            this.secondLevelList.Visible = false;
            // 
            // thirdLevelList
            // 
            this.thirdLevelList.BackColor = System.Drawing.SystemColors.Control;
            this.thirdLevelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLevelList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thirdLevelList.FormattingEnabled = true;
            this.thirdLevelList.ItemHeight = 31;
            this.thirdLevelList.Location = new System.Drawing.Point(815, 168);
            this.thirdLevelList.Name = "thirdLevelList";
            this.thirdLevelList.Size = new System.Drawing.Size(115, 190);
            this.thirdLevelList.TabIndex = 7;
            this.thirdLevelList.Visible = false;
            // 
            // btnNextFirst
            // 
            this.btnNextFirst.Location = new System.Drawing.Point(170, 373);
            this.btnNextFirst.Name = "btnNextFirst";
            this.btnNextFirst.Size = new System.Drawing.Size(75, 23);
            this.btnNextFirst.TabIndex = 8;
            this.btnNextFirst.Text = "Next";
            this.btnNextFirst.UseVisualStyleBackColor = true;
            this.btnNextFirst.Click += new System.EventHandler(this.btnNextFirst_Click);
            // 
            // btnNextSecond
            // 
            this.btnNextSecond.Location = new System.Drawing.Point(568, 373);
            this.btnNextSecond.Name = "btnNextSecond";
            this.btnNextSecond.Size = new System.Drawing.Size(75, 23);
            this.btnNextSecond.TabIndex = 9;
            this.btnNextSecond.Text = "Next";
            this.btnNextSecond.UseVisualStyleBackColor = true;
            this.btnNextSecond.Visible = false;
            this.btnNextSecond.Click += new System.EventHandler(this.btnNextSecond_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(840, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNextSecond);
            this.Controls.Add(this.btnNextFirst);
            this.Controls.Add(this.thirdLevelList);
            this.Controls.Add(this.secondLevelList);
            this.Controls.Add(this.firstLevelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.answerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindingCallNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Training - Identify Areas";
            this.Load += new System.EventHandler(this.FindingCallNumbers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsBar;
        private System.Windows.Forms.ToolStripMenuItem correct20PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorrect5PointsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox firstLevelList;
        private System.Windows.Forms.ListBox secondLevelList;
        private System.Windows.Forms.ListBox thirdLevelList;
        private System.Windows.Forms.Button btnNextFirst;
        private System.Windows.Forms.Button btnNextSecond;
        private System.Windows.Forms.Button btnSubmit;
    }
}