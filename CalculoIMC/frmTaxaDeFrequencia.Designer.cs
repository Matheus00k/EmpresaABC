
namespace CalculoIMC
{
    partial class frmTaxaDeFrequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxaDeFrequencia));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtAcidentados = new System.Windows.Forms.TextBox();
            this.txtFuncionarios = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblNumAci = new System.Windows.Forms.Label();
            this.lblNumFun = new System.Windows.Forms.Label();
            this.lblNumHora = new System.Windows.Forms.Label();
            this.pcbTabela = new System.Windows.Forms.PictureBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblMostraResult = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblMostraQuali = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(595, 412);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(142, 63);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtAcidentados
            // 
            this.txtAcidentados.Location = new System.Drawing.Point(98, 107);
            this.txtAcidentados.Name = "txtAcidentados";
            this.txtAcidentados.Size = new System.Drawing.Size(114, 20);
            this.txtAcidentados.TabIndex = 0;
            // 
            // txtFuncionarios
            // 
            this.txtFuncionarios.Location = new System.Drawing.Point(98, 195);
            this.txtFuncionarios.Name = "txtFuncionarios";
            this.txtFuncionarios.Size = new System.Drawing.Size(114, 20);
            this.txtFuncionarios.TabIndex = 1;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(98, 275);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(114, 20);
            this.txtHoras.TabIndex = 2;
            // 
            // lblNumAci
            // 
            this.lblNumAci.AutoSize = true;
            this.lblNumAci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAci.Location = new System.Drawing.Point(94, 64);
            this.lblNumAci.Name = "lblNumAci";
            this.lblNumAci.Size = new System.Drawing.Size(184, 20);
            this.lblNumAci.TabIndex = 4;
            this.lblNumAci.Text = "Número de Acidentados:";
            // 
            // lblNumFun
            // 
            this.lblNumFun.AutoSize = true;
            this.lblNumFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFun.Location = new System.Drawing.Point(94, 161);
            this.lblNumFun.Name = "lblNumFun";
            this.lblNumFun.Size = new System.Drawing.Size(178, 20);
            this.lblNumFun.TabIndex = 5;
            this.lblNumFun.Text = "Número de Funcionário:";
            // 
            // lblNumHora
            // 
            this.lblNumHora.AutoSize = true;
            this.lblNumHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHora.Location = new System.Drawing.Point(94, 240);
            this.lblNumHora.Name = "lblNumHora";
            this.lblNumHora.Size = new System.Drawing.Size(320, 20);
            this.lblNumHora.TabIndex = 6;
            this.lblNumHora.Text = "Número de Horas Individuais Trabalhadas:   ";
            // 
            // pcbTabela
            // 
            this.pcbTabela.Image = ((System.Drawing.Image)(resources.GetObject("pcbTabela.Image")));
            this.pcbTabela.Location = new System.Drawing.Point(520, 113);
            this.pcbTabela.Name = "pcbTabela";
            this.pcbTabela.Size = new System.Drawing.Size(217, 102);
            this.pcbTabela.TabIndex = 7;
            this.pcbTabela.TabStop = false;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(94, 410);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(96, 20);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "Resultado:";
            // 
            // lblMostraResult
            // 
            this.lblMostraResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMostraResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraResult.Location = new System.Drawing.Point(231, 400);
            this.lblMostraResult.Name = "lblMostraResult";
            this.lblMostraResult.Size = new System.Drawing.Size(107, 40);
            this.lblMostraResult.TabIndex = 9;
            this.lblMostraResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(93, 322);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 34);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(231, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblMostraQuali
            // 
            this.lblMostraQuali.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMostraQuali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraQuali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraQuali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraQuali.Location = new System.Drawing.Point(370, 400);
            this.lblMostraQuali.Name = "lblMostraQuali";
            this.lblMostraQuali.Size = new System.Drawing.Size(141, 41);
            this.lblMostraQuali.TabIndex = 10;
            this.lblMostraQuali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTaxaDeFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblMostraQuali);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMostraResult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.pcbTabela);
            this.Controls.Add(this.lblNumHora);
            this.Controls.Add(this.lblNumFun);
            this.Controls.Add(this.lblNumAci);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtFuncionarios);
            this.Controls.Add(this.txtAcidentados);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTaxaDeFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxa De Frequencia";
            this.Load += new System.EventHandler(this.frmTaxaDeFrequencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtAcidentados;
        private System.Windows.Forms.TextBox txtFuncionarios;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblNumAci;
        private System.Windows.Forms.Label lblNumFun;
        private System.Windows.Forms.Label lblNumHora;
        private System.Windows.Forms.PictureBox pcbTabela;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblMostraResult;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMostraQuali;
    }
}