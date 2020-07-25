namespace GiveTakeCashGuy.O.O
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bobCash = new System.Windows.Forms.Label();
            this.joeCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe tem R$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bob tem R$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "O banco tem R$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 144);
            this.button2.TabIndex = 3;
            this.button2.Text = "Receba R$ 5 de Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 144);
            this.button1.TabIndex = 4;
            this.button1.Text = "De R$ 10 para Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // bobCash
            // 
            this.bobCash.AutoSize = true;
            this.bobCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobCash.Location = new System.Drawing.Point(420, 120);
            this.bobCash.Name = "bobCash";
            this.bobCash.Size = new System.Drawing.Size(34, 25);
            this.bobCash.TabIndex = 5;
            this.bobCash.Text = "50";
            this.bobCash.Click += new System.EventHandler(this.bobCash_Click);
            // 
            // joeCash
            // 
            this.joeCash.AutoSize = true;
            this.joeCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeCash.Location = new System.Drawing.Point(409, 76);
            this.joeCash.Name = "joeCash";
            this.joeCash.Size = new System.Drawing.Size(45, 25);
            this.joeCash.TabIndex = 6;
            this.joeCash.Text = "100";
            this.joeCash.Click += new System.EventHandler(this.joeCash_Click);
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCash.Location = new System.Drawing.Point(409, 174);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(45, 25);
            this.bankCash.TabIndex = 7;
            this.bankCash.Text = "100";
            this.bankCash.Click += new System.EventHandler(this.bankCash_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(103, 439);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(225, 144);
            this.joeGivesToBob.TabIndex = 8;
            this.joeGivesToBob.Text = "Joe dá R$ 10 para Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(412, 439);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(225, 144);
            this.bobGivesToJoe.TabIndex = 9;
            this.bobGivesToJoe.Text = "Bob dá R$ 5 para Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 595);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.joeCash);
            this.Controls.Add(this.bobCash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bobCash;
        private System.Windows.Forms.Label joeCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

