namespace CalculadorDeQuilometragem
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
            this.lblQuilometragemInicial = new System.Windows.Forms.Label();
            this.lblQuilometragemFinal = new System.Windows.Forms.Label();
            this.lblQuantidadeDevida = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numKmInicial = new System.Windows.Forms.NumericUpDown();
            this.numKmFinal = new System.Windows.Forms.NumericUpDown();
            this.btnMostraKm = new System.Windows.Forms.Button();
            this.lblKM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKmInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuilometragemInicial
            // 
            this.lblQuilometragemInicial.AutoSize = true;
            this.lblQuilometragemInicial.Location = new System.Drawing.Point(293, 89);
            this.lblQuilometragemInicial.Name = "lblQuilometragemInicial";
            this.lblQuilometragemInicial.Size = new System.Drawing.Size(109, 13);
            this.lblQuilometragemInicial.TabIndex = 0;
            this.lblQuilometragemInicial.Text = "Quilometragem inicial:";
            // 
            // lblQuilometragemFinal
            // 
            this.lblQuilometragemFinal.AutoSize = true;
            this.lblQuilometragemFinal.Location = new System.Drawing.Point(293, 147);
            this.lblQuilometragemFinal.Name = "lblQuilometragemFinal";
            this.lblQuilometragemFinal.Size = new System.Drawing.Size(105, 13);
            this.lblQuilometragemFinal.TabIndex = 1;
            this.lblQuilometragemFinal.Text = "Quilometragem Final:";
            // 
            // lblQuantidadeDevida
            // 
            this.lblQuantidadeDevida.AutoSize = true;
            this.lblQuantidadeDevida.Location = new System.Drawing.Point(293, 219);
            this.lblQuantidadeDevida.Name = "lblQuantidadeDevida";
            this.lblQuantidadeDevida.Size = new System.Drawing.Size(100, 13);
            this.lblQuantidadeDevida.TabIndex = 2;
            this.lblQuantidadeDevida.Text = "Quantidade devida:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(382, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(435, 219);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 7;
            // 
            // numKmInicial
            // 
            this.numKmInicial.Location = new System.Drawing.Point(424, 82);
            this.numKmInicial.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numKmInicial.Name = "numKmInicial";
            this.numKmInicial.Size = new System.Drawing.Size(120, 20);
            this.numKmInicial.TabIndex = 8;
            // 
            // numKmFinal
            // 
            this.numKmFinal.Location = new System.Drawing.Point(424, 147);
            this.numKmFinal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numKmFinal.Name = "numKmFinal";
            this.numKmFinal.Size = new System.Drawing.Size(120, 20);
            this.numKmFinal.TabIndex = 9;
            // 
            // btnMostraKm
            // 
            this.btnMostraKm.Location = new System.Drawing.Point(482, 291);
            this.btnMostraKm.Name = "btnMostraKm";
            this.btnMostraKm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMostraKm.Size = new System.Drawing.Size(75, 23);
            this.btnMostraKm.TabIndex = 10;
            this.btnMostraKm.Text = "Mostrar quilometragem";
            this.btnMostraKm.UseVisualStyleBackColor = true;
            this.btnMostraKm.Click += new System.EventHandler(this.btnMostraKm_Click);
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(505, 219);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(0, 13);
            this.lblKM.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.btnMostraKm);
            this.Controls.Add(this.numKmFinal);
            this.Controls.Add(this.numKmInicial);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblQuantidadeDevida);
            this.Controls.Add(this.lblQuilometragemFinal);
            this.Controls.Add(this.lblQuilometragemInicial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKmInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuilometragemInicial;
        private System.Windows.Forms.Label lblQuilometragemFinal;
        private System.Windows.Forms.Label lblQuantidadeDevida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numKmInicial;
        private System.Windows.Forms.NumericUpDown numKmFinal;
        private System.Windows.Forms.Button btnMostraKm;
        private System.Windows.Forms.Label lblKM;
    }
}

