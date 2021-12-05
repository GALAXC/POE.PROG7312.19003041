namespace POE.PROG7312._19003041
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnReplaceBooks = new System.Windows.Forms.Button();
            this.btnIdentifyAreas = new System.Windows.Forms.Button();
            this.btnFindCallNums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.Location = new System.Drawing.Point(91, 228);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(156, 66);
            this.btnReplaceBooks.TabIndex = 0;
            this.btnReplaceBooks.Text = "Replacing Books";
            this.btnReplaceBooks.UseVisualStyleBackColor = true;
            this.btnReplaceBooks.Click += new System.EventHandler(this.btnReplaceBooks_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.Location = new System.Drawing.Point(91, 300);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(156, 66);
            this.btnIdentifyAreas.TabIndex = 1;
            this.btnIdentifyAreas.Text = "Identifying Areas";
            this.btnIdentifyAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyAreas.Click += new System.EventHandler(this.BtnIdentifyAreas_Click);
            // 
            // btnFindCallNums
            // 
            this.btnFindCallNums.Location = new System.Drawing.Point(91, 372);
            this.btnFindCallNums.Name = "btnFindCallNums";
            this.btnFindCallNums.Size = new System.Drawing.Size(156, 66);
            this.btnFindCallNums.TabIndex = 2;
            this.btnFindCallNums.Text = "Finding Call Numbers";
            this.btnFindCallNums.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 112);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Library training app!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "What would you like to learn?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindCallNums);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.btnReplaceBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Training - Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplaceBooks;
        private System.Windows.Forms.Button btnIdentifyAreas;
        private System.Windows.Forms.Button btnFindCallNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

