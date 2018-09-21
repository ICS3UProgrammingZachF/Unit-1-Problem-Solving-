namespace moving_cat
{
    partial class frmmovingcat
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
            this.picCat = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.niceCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niceCatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.badCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCat
            // 
            this.picCat.Image = global::moving_cat.Properties.Resources.strateder_cat;
            this.picCat.Location = new System.Drawing.Point(246, 50);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(412, 353);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niceCatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // niceCatToolStripMenuItem
            // 
            this.niceCatToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.niceCatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niceCatToolStripMenuItem1,
            this.badCatToolStripMenuItem});
            this.niceCatToolStripMenuItem.Name = "niceCatToolStripMenuItem";
            this.niceCatToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.niceCatToolStripMenuItem.Text = "Cat";
            // 
            // niceCatToolStripMenuItem1
            // 
            this.niceCatToolStripMenuItem1.Name = "niceCatToolStripMenuItem1";
            this.niceCatToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.niceCatToolStripMenuItem1.Text = "Nice Cat";
            this.niceCatToolStripMenuItem1.Click += new System.EventHandler(this.niceCatToolStripMenuItem1_Click);
            // 
            // badCatToolStripMenuItem
            // 
            this.badCatToolStripMenuItem.Name = "badCatToolStripMenuItem";
            this.badCatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.badCatToolStripMenuItem.Text = "Bad Cat";
            this.badCatToolStripMenuItem.Click += new System.EventHandler(this.badCatToolStripMenuItem_Click);
            // 
            // frmmovingcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 415);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmovingcat";
            this.Text = "movingcat";
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem niceCatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niceCatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem badCatToolStripMenuItem;
    }
}

