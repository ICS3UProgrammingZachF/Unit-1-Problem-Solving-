namespace PizzaCost
{
    partial class PizzaCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaCost));
            this.nudpizza = new System.Windows.Forms.NumericUpDown();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblanswersub = new System.Windows.Forms.Label();
            this.lblanwsertotal = new System.Windows.Forms.Label();
            this.nubpizzas = new System.Windows.Forms.NumericUpDown();
            this.lbltax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubpizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudpizza
            // 
            this.nudpizza.Location = new System.Drawing.Point(353, 12);
            this.nudpizza.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nudpizza.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudpizza.Name = "nudpizza";
            this.nudpizza.Size = new System.Drawing.Size(120, 20);
            this.nudpizza.TabIndex = 0;
            this.nudpizza.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudpizza.ValueChanged += new System.EventHandler(this.nudpizza_ValueChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(398, 152);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblanswersub
            // 
            this.lblanswersub.AutoSize = true;
            this.lblanswersub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswersub.Location = new System.Drawing.Point(400, 242);
            this.lblanswersub.Name = "lblanswersub";
            this.lblanswersub.Size = new System.Drawing.Size(74, 24);
            this.lblanswersub.TabIndex = 3;
            this.lblanswersub.Text = "Answer";
            // 
            // lblanwsertotal
            // 
            this.lblanwsertotal.AutoSize = true;
            this.lblanwsertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanwsertotal.Location = new System.Drawing.Point(399, 320);
            this.lblanwsertotal.Name = "lblanwsertotal";
            this.lblanwsertotal.Size = new System.Drawing.Size(74, 24);
            this.lblanwsertotal.TabIndex = 4;
            this.lblanwsertotal.Text = "Answer";
            // 
            // nubpizzas
            // 
            this.nubpizzas.Location = new System.Drawing.Point(353, 61);
            this.nubpizzas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nubpizzas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubpizzas.Name = "nubpizzas";
            this.nubpizzas.Size = new System.Drawing.Size(120, 20);
            this.nubpizzas.TabIndex = 5;
            this.nubpizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.Location = new System.Drawing.Point(399, 286);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(74, 24);
            this.lbltax.TabIndex = 6;
            this.lbltax.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "the size of the pizza ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "number of pizzas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "total";
            // 
            // PizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.nubpizzas);
            this.Controls.Add(this.lblanwsertotal);
            this.Controls.Add(this.lblanswersub);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.nudpizza);
            this.Name = "PizzaCost";
            this.Text = "Pizza cost";
            this.Load += new System.EventHandler(this.PizzaCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubpizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudpizza;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblanswersub;
        private System.Windows.Forms.Label lblanwsertotal;
        private System.Windows.Forms.NumericUpDown nubpizzas;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

