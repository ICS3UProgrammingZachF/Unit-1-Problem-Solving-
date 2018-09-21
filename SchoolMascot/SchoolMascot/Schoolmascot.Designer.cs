namespace SchoolMascot
{
    partial class frmSchoolmascot
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuschools = new System.Windows.Forms.ToolStripMenuItem();
            this.immaculataHighSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.louisRielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ashburyCollegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisgarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblschools = new System.Windows.Forms.Label();
            this.lblSchoolMotto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuschools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuschools
            // 
            this.mnuschools.BackColor = System.Drawing.Color.White;
            this.mnuschools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.immaculataHighSchoolToolStripMenuItem,
            this.louisRielToolStripMenuItem,
            this.ashburyCollegeToolStripMenuItem,
            this.lisgarToolStripMenuItem});
            this.mnuschools.Name = "mnuschools";
            this.mnuschools.Size = new System.Drawing.Size(60, 20);
            this.mnuschools.Text = "Schools";
            // 
            // immaculataHighSchoolToolStripMenuItem
            // 
            this.immaculataHighSchoolToolStripMenuItem.Name = "immaculataHighSchoolToolStripMenuItem";
            this.immaculataHighSchoolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.immaculataHighSchoolToolStripMenuItem.Text = "Immaculata ";
            this.immaculataHighSchoolToolStripMenuItem.Click += new System.EventHandler(this.immaculataHighSchoolToolStripMenuItem_Click);
            // 
            // louisRielToolStripMenuItem
            // 
            this.louisRielToolStripMenuItem.Name = "louisRielToolStripMenuItem";
            this.louisRielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.louisRielToolStripMenuItem.Text = "Louis-Riel";
            this.louisRielToolStripMenuItem.Click += new System.EventHandler(this.louisRielToolStripMenuItem_Click);
            // 
            // ashburyCollegeToolStripMenuItem
            // 
            this.ashburyCollegeToolStripMenuItem.Name = "ashburyCollegeToolStripMenuItem";
            this.ashburyCollegeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ashburyCollegeToolStripMenuItem.Text = "Lisgar";
            this.ashburyCollegeToolStripMenuItem.Click += new System.EventHandler(this.ashburyCollegeToolStripMenuItem_Click);
            // 
            // lisgarToolStripMenuItem
            // 
            this.lisgarToolStripMenuItem.Name = "lisgarToolStripMenuItem";
            this.lisgarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lisgarToolStripMenuItem.Text = "Ashbury";
            this.lisgarToolStripMenuItem.Click += new System.EventHandler(this.lisgarToolStripMenuItem_Click);
            // 
            // lblschools
            // 
            this.lblschools.AutoSize = true;
            this.lblschools.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschools.Location = new System.Drawing.Point(243, 58);
            this.lblschools.Name = "lblschools";
            this.lblschools.Size = new System.Drawing.Size(118, 31);
            this.lblschools.TabIndex = 1;
            this.lblschools.Text = "Schools";
            this.lblschools.Click += new System.EventHandler(this.lblschools_Click);
            // 
            // lblSchoolMotto
            // 
            this.lblSchoolMotto.AutoSize = true;
            this.lblSchoolMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMotto.Location = new System.Drawing.Point(211, 150);
            this.lblSchoolMotto.Name = "lblSchoolMotto";
            this.lblSchoolMotto.Size = new System.Drawing.Size(184, 31);
            this.lblSchoolMotto.TabIndex = 2;
            this.lblSchoolMotto.Text = "School Motto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSchoolMotto);
            this.groupBox1.Controls.Add(this.lblschools);
            this.groupBox1.Location = new System.Drawing.Point(74, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // frmSchoolmascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSchoolmascot";
            this.Text = "Schoolmascot";
            this.Load += new System.EventHandler(this.frmSchoolmascot_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuschools;
        private System.Windows.Forms.ToolStripMenuItem immaculataHighSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem louisRielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ashburyCollegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisgarToolStripMenuItem;
        private System.Windows.Forms.Label lblschools;
        private System.Windows.Forms.Label lblSchoolMotto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

