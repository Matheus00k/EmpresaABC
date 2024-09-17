
namespace CalculoIMC
{
    partial class frmFolhadePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhadePagamento));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSB = new System.Windows.Forms.Label();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblMostraINSS = new System.Windows.Forms.Label();
            this.lblMostraIR = new System.Windows.Forms.Label();
            this.lblMostraCooperativa = new System.Windows.Forms.Label();
            this.lblMostraSL = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rdbClassA = new System.Windows.Forms.RadioButton();
            this.rdbClassB = new System.Windows.Forms.RadioButton();
            this.rdbClassC = new System.Windows.Forms.RadioButton();
            this.lblCooperativaa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(642, 202);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSB.Location = new System.Drawing.Point(17, 80);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(105, 20);
            this.lblSB.TabIndex = 1;
            this.lblSB.Text = "Salário Bruto:";
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(138, 82);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(100, 20);
            this.txtSB.TabIndex = 0;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(160, 307);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(51, 20);
            this.lblINSS.TabIndex = 5;
            this.lblINSS.Text = "INSS:";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(283, 307);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(30, 20);
            this.lblIR.TabIndex = 6;
            this.lblIR.Text = "IR:";
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCooperativa.Location = new System.Drawing.Point(375, 307);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(98, 20);
            this.lblCooperativa.TabIndex = 7;
            this.lblCooperativa.Text = "Cooperativa:";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(508, 307);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(117, 20);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Salário Líquido:";
            // 
            // lblMostraINSS
            // 
            this.lblMostraINSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraINSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraINSS.Location = new System.Drawing.Point(139, 348);
            this.lblMostraINSS.Name = "lblMostraINSS";
            this.lblMostraINSS.Size = new System.Drawing.Size(85, 20);
            this.lblMostraINSS.TabIndex = 9;
            // 
            // lblMostraIR
            // 
            this.lblMostraIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraIR.Location = new System.Drawing.Point(258, 348);
            this.lblMostraIR.Name = "lblMostraIR";
            this.lblMostraIR.Size = new System.Drawing.Size(85, 20);
            this.lblMostraIR.TabIndex = 10;
            // 
            // lblMostraCooperativa
            // 
            this.lblMostraCooperativa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraCooperativa.Location = new System.Drawing.Point(379, 348);
            this.lblMostraCooperativa.Name = "lblMostraCooperativa";
            this.lblMostraCooperativa.Size = new System.Drawing.Size(85, 20);
            this.lblMostraCooperativa.TabIndex = 11;
            // 
            // lblMostraSL
            // 
            this.lblMostraSL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraSL.Location = new System.Drawing.Point(519, 348);
            this.lblMostraSL.Name = "lblMostraSL";
            this.lblMostraSL.Size = new System.Drawing.Size(85, 20);
            this.lblMostraSL.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(68, 202);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(352, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rdbClassA
            // 
            this.rdbClassA.AutoSize = true;
            this.rdbClassA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClassA.Location = new System.Drawing.Point(21, 162);
            this.rdbClassA.Name = "rdbClassA";
            this.rdbClassA.Size = new System.Drawing.Size(192, 20);
            this.rdbClassA.TabIndex = 1;
            this.rdbClassA.TabStop = true;
            this.rdbClassA.Text = "Classe A: 30% De desconto";
            this.rdbClassA.UseVisualStyleBackColor = true;
            // 
            // rdbClassB
            // 
            this.rdbClassB.AutoSize = true;
            this.rdbClassB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClassB.Location = new System.Drawing.Point(308, 162);
            this.rdbClassB.Name = "rdbClassB";
            this.rdbClassB.Size = new System.Drawing.Size(184, 20);
            this.rdbClassB.TabIndex = 2;
            this.rdbClassB.TabStop = true;
            this.rdbClassB.Text = "Classe B: 20% de Dsconto";
            this.rdbClassB.UseVisualStyleBackColor = true;
            // 
            // rdbClassC
            // 
            this.rdbClassC.AutoSize = true;
            this.rdbClassC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClassC.Location = new System.Drawing.Point(580, 162);
            this.rdbClassC.Name = "rdbClassC";
            this.rdbClassC.Size = new System.Drawing.Size(192, 20);
            this.rdbClassC.TabIndex = 3;
            this.rdbClassC.TabStop = true;
            this.rdbClassC.Text = "Classe C: 10% de Desconto";
            this.rdbClassC.UseVisualStyleBackColor = true;
            // 
            // lblCooperativaa
            // 
            this.lblCooperativaa.AutoSize = true;
            this.lblCooperativaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCooperativaa.Location = new System.Drawing.Point(17, 124);
            this.lblCooperativaa.Name = "lblCooperativaa";
            this.lblCooperativaa.Size = new System.Drawing.Size(98, 20);
            this.lblCooperativaa.TabIndex = 17;
            this.lblCooperativaa.Text = "Cooperativa:";
            // 
            // frmFolhadePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblCooperativaa);
            this.Controls.Add(this.rdbClassC);
            this.Controls.Add(this.rdbClassB);
            this.Controls.Add(this.rdbClassA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMostraSL);
            this.Controls.Add(this.lblMostraCooperativa);
            this.Controls.Add(this.lblMostraIR);
            this.Controls.Add(this.lblMostraINSS);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblCooperativa);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.txtSB);
            this.Controls.Add(this.lblSB);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhadePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblCooperativa;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblMostraINSS;
        private System.Windows.Forms.Label lblMostraIR;
        private System.Windows.Forms.Label lblMostraCooperativa;
        private System.Windows.Forms.Label lblMostraSL;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rdbClassA;
        private System.Windows.Forms.RadioButton rdbClassB;
        private System.Windows.Forms.RadioButton rdbClassC;
        private System.Windows.Forms.Label lblCooperativaa;
    }
}