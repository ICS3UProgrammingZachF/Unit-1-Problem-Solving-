namespace AreaAndPerimeter
{
    partial class AareaPerimeter
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
            this.lblLenght = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblnamearea = new System.Windows.Forms.Label();
            this.lblnameperimeter = new System.Windows.Forms.Label();
            this.lblanswerarea = new System.Windows.Forms.Label();
            this.lblanswerperimeter = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.BackColor = System.Drawing.Color.White;
            this.lblLenght.Location = new System.Drawing.Point(244, 92);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(40, 13);
            this.lblLenght.TabIndex = 0;
            this.lblLenght.Text = "Lenght";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.White;
            this.lblWidth.Location = new System.Drawing.Point(244, 135);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(32, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "width";
            // 
            // lblnamearea
            // 
            this.lblnamearea.AutoSize = true;
            this.lblnamearea.BackColor = System.Drawing.Color.White;
            this.lblnamearea.Location = new System.Drawing.Point(278, 220);
            this.lblnamearea.Name = "lblnamearea";
            this.lblnamearea.Size = new System.Drawing.Size(29, 13);
            this.lblnamearea.TabIndex = 2;
            this.lblnamearea.Text = "Area";
            // 
            // lblnameperimeter
            // 
            this.lblnameperimeter.AutoSize = true;
            this.lblnameperimeter.BackColor = System.Drawing.Color.White;
            this.lblnameperimeter.Location = new System.Drawing.Point(278, 277);
            this.lblnameperimeter.Name = "lblnameperimeter";
            this.lblnameperimeter.Size = new System.Drawing.Size(51, 13);
            this.lblnameperimeter.TabIndex = 3;
            this.lblnameperimeter.Text = "Perimeter";
            // 
            // lblanswerarea
            // 
            this.lblanswerarea.AutoSize = true;
            this.lblanswerarea.BackColor = System.Drawing.Color.White;
            this.lblanswerarea.Location = new System.Drawing.Point(403, 220);
            this.lblanswerarea.Name = "lblanswerarea";
            this.lblanswerarea.Size = new System.Drawing.Size(35, 13);
            this.lblanswerarea.TabIndex = 4;
            this.lblanswerarea.Text = "label3";
            // 
            // lblanswerperimeter
            // 
            this.lblanswerperimeter.AutoSize = true;
            this.lblanswerperimeter.BackColor = System.Drawing.Color.White;
            this.lblanswerperimeter.Location = new System.Drawing.Point(403, 277);
            this.lblanswerperimeter.Name = "lblanswerperimeter";
            this.lblanswerperimeter.Size = new System.Drawing.Size(35, 13);
            this.lblanswerperimeter.TabIndex = 5;
            this.lblanswerperimeter.Text = "label3";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(358, 92);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(142, 20);
            this.txtLength.TabIndex = 6;
            this.txtLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(358, 135);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(142, 20);
            this.txtWidth.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Caluculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AareaPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(767, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblanswerperimeter);
            this.Controls.Add(this.lblanswerarea);
            this.Controls.Add(this.lblnameperimeter);
            this.Controls.Add(this.lblnamearea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLenght);
            this.Name = "AareaPerimeter";
            this.Text = "perimeter and area";
            this.Load += new System.EventHandler(this.AareaPerimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblnamearea;
        private System.Windows.Forms.Label lblnameperimeter;
        private System.Windows.Forms.Label lblanswerarea;
        private System.Windows.Forms.Label lblanswerperimeter;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button button1;
    }
}

