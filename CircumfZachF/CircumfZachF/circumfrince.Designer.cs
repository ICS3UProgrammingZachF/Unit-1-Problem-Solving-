namespace CircumfZachF
{
    partial class circumfrece
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
            this.lblCircumF = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtcircum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblanwser1 = new System.Windows.Forms.Label();
            this.lblanwser2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCircumF
            // 
            this.lblCircumF.AutoSize = true;
            this.lblCircumF.BackColor = System.Drawing.Color.Transparent;
            this.lblCircumF.Font = new System.Drawing.Font("Simplex_IV50", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumF.ForeColor = System.Drawing.Color.Red;
            this.lblCircumF.Location = new System.Drawing.Point(64, 87);
            this.lblCircumF.Name = "lblCircumF";
            this.lblCircumF.Size = new System.Drawing.Size(377, 37);
            this.lblCircumF.TabIndex = 0;
            this.lblCircumF.Text = "insert the Radius here:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fillToolStripMenuItem.Text = "File";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.fillToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // txtcircum
            // 
            this.txtcircum.Location = new System.Drawing.Point(468, 100);
            this.txtcircum.Name = "txtcircum";
            this.txtcircum.Size = new System.Drawing.Size(197, 20);
            this.txtcircum.TabIndex = 2;
            this.txtcircum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(83, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblanwser1
            // 
            this.lblanwser1.AutoSize = true;
            this.lblanwser1.BackColor = System.Drawing.Color.Transparent;
            this.lblanwser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanwser1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblanwser1.Location = new System.Drawing.Point(54, 374);
            this.lblanwser1.Name = "lblanwser1";
            this.lblanwser1.Size = new System.Drawing.Size(212, 29);
            this.lblanwser1.TabIndex = 4;
            this.lblanwser1.Text = "the circumfrince is:\r\n";
            this.lblanwser1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblanwser2
            // 
            this.lblanwser2.AutoSize = true;
            this.lblanwser2.BackColor = System.Drawing.Color.Transparent;
            this.lblanwser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanwser2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblanwser2.Location = new System.Drawing.Point(54, 443);
            this.lblanwser2.Name = "lblanwser2";
            this.lblanwser2.Size = new System.Drawing.Size(79, 29);
            this.lblanwser2.TabIndex = 5;
            this.lblanwser2.Text = "label2";
            // 
            // circumfrece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CircumfZachF.Properties.Resources.circumfbackrond;
            this.ClientSize = new System.Drawing.Size(714, 523);
            this.Controls.Add(this.lblanwser2);
            this.Controls.Add(this.lblanwser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcircum);
            this.Controls.Add(this.lblCircumF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "circumfrece";
            this.Text = "circumfece";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCircumF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox txtcircum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblanwser1;
        private System.Windows.Forms.Label lblanwser2;
    }
}

