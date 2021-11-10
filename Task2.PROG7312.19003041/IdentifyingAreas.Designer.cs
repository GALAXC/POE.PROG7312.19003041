
namespace Task2.PROG7312._19003041
{
    partial class IdentifyingAreas
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyingAreas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsBar = new System.Windows.Forms.ToolStripMenuItem();
            this.correct20PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incorrect5PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dividerLine1 = new System.Windows.Forms.Label();
            this.dividerLine2 = new System.Windows.Forms.Label();
            this.dividerLine3 = new System.Windows.Forms.Label();
            this.dividerLine4 = new System.Windows.Forms.Label();
            this.dividerLine5 = new System.Windows.Forms.Label();
            this.dividerLine6 = new System.Windows.Forms.Label();
            this.dividerLine7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.descList = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pointsBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
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
            // bookList
            // 
            this.bookList.AllowDrop = true;
            this.bookList.BackColor = System.Drawing.Color.White;
            this.bookList.Cursor = System.Windows.Forms.Cursors.No;
            this.bookList.HideSelection = false;
            this.bookList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.bookList.Location = new System.Drawing.Point(12, 27);
            this.bookList.MultiSelect = false;
            this.bookList.Name = "bookList";
            this.bookList.Scrollable = false;
            this.bookList.Size = new System.Drawing.Size(250, 470);
            this.bookList.TabIndex = 4;
            this.bookList.TileSize = new System.Drawing.Size(64, 25);
            this.bookList.UseCompatibleStateImageBehavior = false;
            this.bookList.View = System.Windows.Forms.View.SmallIcon;
            this.bookList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bookList_MouseDown);
            this.bookList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bookList_MouseMove);
            this.bookList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bookList_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dividerLine1
            // 
            this.dividerLine1.AutoSize = true;
            this.dividerLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine1.Location = new System.Drawing.Point(268, 46);
            this.dividerLine1.Name = "dividerLine1";
            this.dividerLine1.Size = new System.Drawing.Size(140, 16);
            this.dividerLine1.TabIndex = 12;
            this.dividerLine1.Text = "---------------------------------";
            // 
            // dividerLine2
            // 
            this.dividerLine2.AutoSize = true;
            this.dividerLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine2.Location = new System.Drawing.Point(267, 105);
            this.dividerLine2.Name = "dividerLine2";
            this.dividerLine2.Size = new System.Drawing.Size(140, 16);
            this.dividerLine2.TabIndex = 13;
            this.dividerLine2.Text = "---------------------------------";
            // 
            // dividerLine3
            // 
            this.dividerLine3.AutoSize = true;
            this.dividerLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine3.Location = new System.Drawing.Point(267, 162);
            this.dividerLine3.Name = "dividerLine3";
            this.dividerLine3.Size = new System.Drawing.Size(140, 16);
            this.dividerLine3.TabIndex = 14;
            this.dividerLine3.Text = "---------------------------------";
            // 
            // dividerLine4
            // 
            this.dividerLine4.AutoSize = true;
            this.dividerLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine4.Location = new System.Drawing.Point(268, 225);
            this.dividerLine4.Name = "dividerLine4";
            this.dividerLine4.Size = new System.Drawing.Size(140, 16);
            this.dividerLine4.TabIndex = 15;
            this.dividerLine4.Text = "---------------------------------";
            // 
            // dividerLine5
            // 
            this.dividerLine5.AutoSize = true;
            this.dividerLine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine5.Location = new System.Drawing.Point(268, 282);
            this.dividerLine5.Name = "dividerLine5";
            this.dividerLine5.Size = new System.Drawing.Size(140, 16);
            this.dividerLine5.TabIndex = 16;
            this.dividerLine5.Text = "---------------------------------";
            // 
            // dividerLine6
            // 
            this.dividerLine6.AutoSize = true;
            this.dividerLine6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine6.Location = new System.Drawing.Point(267, 343);
            this.dividerLine6.Name = "dividerLine6";
            this.dividerLine6.Size = new System.Drawing.Size(140, 16);
            this.dividerLine6.TabIndex = 17;
            this.dividerLine6.Text = "---------------------------------";
            // 
            // dividerLine7
            // 
            this.dividerLine7.AutoSize = true;
            this.dividerLine7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLine7.Location = new System.Drawing.Point(268, 400);
            this.dividerLine7.Name = "dividerLine7";
            this.dividerLine7.Size = new System.Drawing.Size(140, 16);
            this.dividerLine7.TabIndex = 18;
            this.dividerLine7.Text = "---------------------------------";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(250, 502);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 40);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // descList
            // 
            this.descList.AllowDrop = true;
            this.descList.BackColor = System.Drawing.Color.White;
            this.descList.Cursor = System.Windows.Forms.Cursors.No;
            this.descList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descList.HideSelection = false;
            this.descList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.descList.Location = new System.Drawing.Point(413, 27);
            this.descList.MultiSelect = false;
            this.descList.Name = "descList";
            this.descList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descList.Scrollable = false;
            this.descList.Size = new System.Drawing.Size(250, 470);
            this.descList.TabIndex = 20;
            this.descList.TileSize = new System.Drawing.Size(128, 50);
            this.descList.UseCompatibleStateImageBehavior = false;
            this.descList.View = System.Windows.Forms.View.List;
            this.descList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.descList_MouseDown);
            this.descList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.descList_MouseMove);
            this.descList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.descList_MouseUp);
            // 
            // IdentifyingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 554);
            this.Controls.Add(this.descList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dividerLine7);
            this.Controls.Add(this.dividerLine6);
            this.Controls.Add(this.dividerLine5);
            this.Controls.Add(this.dividerLine4);
            this.Controls.Add(this.dividerLine3);
            this.Controls.Add(this.dividerLine2);
            this.Controls.Add(this.dividerLine1);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IdentifyingAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Training - Identify Areas";
            this.Load += new System.EventHandler(this.IdentifyingAreas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsBar;
        private System.Windows.Forms.ToolStripMenuItem correct20PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorrect5PointsToolStripMenuItem;
        private System.Windows.Forms.ListView bookList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label dividerLine1;
        private System.Windows.Forms.Label dividerLine2;
        private System.Windows.Forms.Label dividerLine3;
        private System.Windows.Forms.Label dividerLine4;
        private System.Windows.Forms.Label dividerLine5;
        private System.Windows.Forms.Label dividerLine6;
        private System.Windows.Forms.Label dividerLine7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView descList;
    }
}