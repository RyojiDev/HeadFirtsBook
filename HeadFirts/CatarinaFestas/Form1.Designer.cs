namespace CatarinaFestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabBithday = new System.Windows.Forms.TabControl();
            this.tbcBirthday = new System.Windows.Forms.TabPage();
            this.numberWords = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRateValue = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblChic = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.numberOfPeaple = new System.Windows.Forms.NumericUpDown();
            this.chkWriteonCake = new System.Windows.Forms.CheckBox();
            this.chkChic = new System.Windows.Forms.CheckBox();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBithdayParty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcDinnerParty = new System.Windows.Forms.TabPage();
            this.lblCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkOpcaoSaudavel = new System.Windows.Forms.CheckBox();
            this.chkDecoracaoChique = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabBithday.SuspendLayout();
            this.tbcBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeaple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcDinnerParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBithday
            // 
            this.tabBithday.Controls.Add(this.tbcBirthday);
            this.tabBithday.Controls.Add(this.tbcDinnerParty);
            this.tabBithday.Location = new System.Drawing.Point(30, 25);
            this.tabBithday.Name = "tabBithday";
            this.tabBithday.SelectedIndex = 0;
            this.tabBithday.Size = new System.Drawing.Size(741, 394);
            this.tabBithday.TabIndex = 0;
            // 
            // tbcBirthday
            // 
            this.tbcBirthday.BackColor = System.Drawing.Color.Beige;
            this.tbcBirthday.Controls.Add(this.numberWords);
            this.tbcBirthday.Controls.Add(this.label6);
            this.tbcBirthday.Controls.Add(this.label5);
            this.tbcBirthday.Controls.Add(this.lblRateValue);
            this.tbcBirthday.Controls.Add(this.lblRate);
            this.tbcBirthday.Controls.Add(this.lblChic);
            this.tbcBirthday.Controls.Add(this.lblNormal);
            this.tbcBirthday.Controls.Add(this.lblTotalValue);
            this.tbcBirthday.Controls.Add(this.numberOfPeaple);
            this.tbcBirthday.Controls.Add(this.chkWriteonCake);
            this.tbcBirthday.Controls.Add(this.chkChic);
            this.tbcBirthday.Controls.Add(this.chkNormal);
            this.tbcBirthday.Controls.Add(this.pictureBox1);
            this.tbcBirthday.Controls.Add(this.lblBithdayParty);
            this.tbcBirthday.Controls.Add(this.label3);
            this.tbcBirthday.Controls.Add(this.label1);
            this.tbcBirthday.Location = new System.Drawing.Point(4, 22);
            this.tbcBirthday.Name = "tbcBirthday";
            this.tbcBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tbcBirthday.Size = new System.Drawing.Size(733, 368);
            this.tbcBirthday.TabIndex = 0;
            this.tbcBirthday.Text = "Birthday";
            // 
            // numberWords
            // 
            this.numberWords.Location = new System.Drawing.Point(282, 192);
            this.numberWords.Name = "numberWords";
            this.numberWords.Size = new System.Drawing.Size(120, 20);
            this.numberWords.TabIndex = 20;
            this.numberWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberWords.Visible = false;
            this.numberWords.ValueChanged += new System.EventHandler(this.Tbc_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "value per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Party Decoration";
            // 
            // lblRateValue
            // 
            this.lblRateValue.AutoSize = true;
            this.lblRateValue.Location = new System.Drawing.Point(299, 226);
            this.lblRateValue.Name = "lblRateValue";
            this.lblRateValue.Size = new System.Drawing.Size(60, 13);
            this.lblRateValue.TabIndex = 17;
            this.lblRateValue.Text = "Value Rate";
            this.lblRateValue.Visible = false;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(141, 221);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(39, 18);
            this.lblRate.TabIndex = 16;
            this.lblRate.Text = "Rate";
            // 
            // lblChic
            // 
            this.lblChic.AutoSize = true;
            this.lblChic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChic.Location = new System.Drawing.Point(322, 161);
            this.lblChic.Name = "lblChic";
            this.lblChic.Size = new System.Drawing.Size(67, 18);
            this.lblChic.TabIndex = 14;
            this.lblChic.Text = "15,00 R$";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(322, 135);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(59, 18);
            this.lblNormal.TabIndex = 13;
            this.lblNormal.Text = "7,50 R$";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(305, 256);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(30, 13);
            this.lblTotalValue.TabIndex = 12;
            this.lblTotalValue.Text = "valor";
            this.lblTotalValue.Visible = false;
            // 
            // numberOfPeaple
            // 
            this.numberOfPeaple.Location = new System.Drawing.Point(282, 71);
            this.numberOfPeaple.Name = "numberOfPeaple";
            this.numberOfPeaple.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeaple.TabIndex = 11;
            this.numberOfPeaple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfPeaple.ValueChanged += new System.EventHandler(this.Tbc_Load);
            // 
            // chkWriteonCake
            // 
            this.chkWriteonCake.AutoSize = true;
            this.chkWriteonCake.Location = new System.Drawing.Point(144, 192);
            this.chkWriteonCake.Name = "chkWriteonCake";
            this.chkWriteonCake.Size = new System.Drawing.Size(93, 17);
            this.chkWriteonCake.TabIndex = 10;
            this.chkWriteonCake.Text = "Write on cake";
            this.chkWriteonCake.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkWriteonCake.UseVisualStyleBackColor = true;
            this.chkWriteonCake.CheckedChanged += new System.EventHandler(this.Tbc_Load);
            // 
            // chkChic
            // 
            this.chkChic.AutoSize = true;
            this.chkChic.Location = new System.Drawing.Point(144, 161);
            this.chkChic.Name = "chkChic";
            this.chkChic.Size = new System.Drawing.Size(47, 17);
            this.chkChic.TabIndex = 9;
            this.chkChic.Text = "Chic";
            this.chkChic.UseVisualStyleBackColor = true;
            this.chkChic.CheckedChanged += new System.EventHandler(this.Tbc_Load);
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(144, 138);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(59, 17);
            this.chkNormal.TabIndex = 8;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.Tbc_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 238);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblBithdayParty
            // 
            this.lblBithdayParty.AutoSize = true;
            this.lblBithdayParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBithdayParty.Location = new System.Drawing.Point(238, 17);
            this.lblBithdayParty.Name = "lblBithdayParty";
            this.lblBithdayParty.Size = new System.Drawing.Size(159, 20);
            this.lblBithdayParty.TabIndex = 6;
            this.lblBithdayParty.Text = "Birthday party quotes";
            this.lblBithdayParty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total party value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Of People:";
            // 
            // tbcDinnerParty
            // 
            this.tbcDinnerParty.Controls.Add(this.numericUpDown1);
            this.tbcDinnerParty.Controls.Add(this.lblCostLabel);
            this.tbcDinnerParty.Controls.Add(this.label4);
            this.tbcDinnerParty.Controls.Add(this.label2);
            this.tbcDinnerParty.Controls.Add(this.chkOpcaoSaudavel);
            this.tbcDinnerParty.Controls.Add(this.chkDecoracaoChique);
            this.tbcDinnerParty.Location = new System.Drawing.Point(4, 22);
            this.tbcDinnerParty.Name = "tbcDinnerParty";
            this.tbcDinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDinnerParty.Size = new System.Drawing.Size(733, 368);
            this.tbcDinnerParty.TabIndex = 1;
            this.tbcDinnerParty.Text = "Dinner";
            this.tbcDinnerParty.UseVisualStyleBackColor = true;
            this.tbcDinnerParty.Click += new System.EventHandler(this.tbcDinnerParty_Click);
            this.Load += new System.EventHandler(this.CarregarTab_load);
            // 
            // lblCostLabel
            // 
            this.lblCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostLabel.Location = new System.Drawing.Point(63, 157);
            this.lblCostLabel.Name = "lblCostLabel";
            this.lblCostLabel.Size = new System.Drawing.Size(100, 13);
            this.lblCostLabel.TabIndex = 4;
            this.lblCostLabel.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de pessoas";
            // 
            // chkOpcaoSaudavel
            // 
            this.chkOpcaoSaudavel.AutoSize = true;
            this.chkOpcaoSaudavel.Location = new System.Drawing.Point(22, 108);
            this.chkOpcaoSaudavel.Name = "chkOpcaoSaudavel";
            this.chkOpcaoSaudavel.Size = new System.Drawing.Size(104, 17);
            this.chkOpcaoSaudavel.TabIndex = 1;
            this.chkOpcaoSaudavel.Text = "Opção saudável";
            this.chkOpcaoSaudavel.UseVisualStyleBackColor = true;
            this.chkOpcaoSaudavel.CheckedChanged += new System.EventHandler(this.chkOpcaoSaudavel_CheckedChanged);
            // 
            // chkDecoracaoChique
            // 
            this.chkDecoracaoChique.AutoSize = true;
            this.chkDecoracaoChique.Location = new System.Drawing.Point(22, 68);
            this.chkDecoracaoChique.Name = "chkDecoracaoChique";
            this.chkDecoracaoChique.Size = new System.Drawing.Size(115, 17);
            this.chkDecoracaoChique.TabIndex = 0;
            this.chkDecoracaoChique.Text = "Decoração Chique";
            this.chkDecoracaoChique.UseVisualStyleBackColor = true;
            this.chkDecoracaoChique.CheckedChanged += new System.EventHandler(this.chkDecoracaoChique_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBithday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBithday.ResumeLayout(false);
            this.tbcBirthday.ResumeLayout(false);
            this.tbcBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeaple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcDinnerParty.ResumeLayout(false);
            this.tbcDinnerParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBithday;
        private System.Windows.Forms.TabPage tbcBirthday;
        private System.Windows.Forms.TabPage tbcDinnerParty;
        private System.Windows.Forms.Label lblBithdayParty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.NumericUpDown numberOfPeaple;
        private System.Windows.Forms.CheckBox chkChic;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.Label lblChic;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.CheckBox chkWriteonCake;
        private System.Windows.Forms.Label lblRateValue;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberWords;
        private System.Windows.Forms.Label lblCostLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkOpcaoSaudavel;
        private System.Windows.Forms.CheckBox chkDecoracaoChique;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

