
namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.lblMostraResultado = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpbOperadores = new System.Windows.Forms.GroupBox();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(51, 61);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(74, 20);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "V&ariável&1";
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel2.Location = new System.Drawing.Point(51, 193);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(74, 20);
            this.lblVariavel2.TabIndex = 1;
            this.lblVariavel2.Text = "Variável&2";
            // 
            // lblMostraResultado
            // 
            this.lblMostraResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraResultado.Location = new System.Drawing.Point(579, 80);
            this.lblMostraResultado.Name = "lblMostraResultado";
            this.lblMostraResultado.Size = new System.Drawing.Size(136, 86);
            this.lblMostraResultado.TabIndex = 2;
            this.lblMostraResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(146, 61);
            this.txtVariavel1.MaxLength = 10;
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(89, 20);
            this.txtVariavel1.TabIndex = 0;
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(146, 193);
            this.txtVariavel2.MaxLength = 10;
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(89, 20);
            this.txtVariavel2.TabIndex = 1;
            // 
            // gpbOperadores
            // 
            this.gpbOperadores.Controls.Add(this.rdbDivisao);
            this.gpbOperadores.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperadores.Controls.Add(this.rdbSubtracao);
            this.gpbOperadores.Controls.Add(this.rdbAdicao);
            this.gpbOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperadores.Location = new System.Drawing.Point(314, 150);
            this.gpbOperadores.Name = "gpbOperadores";
            this.gpbOperadores.Size = new System.Drawing.Size(157, 210);
            this.gpbOperadores.TabIndex = 5;
            this.gpbOperadores.TabStop = false;
            this.gpbOperadores.Text = "Operador";
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(23, 159);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(84, 20);
            this.rdbDivisao.TabIndex = 5;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "&Divisão(/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(23, 122);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(118, 20);
            this.rdbMultiplicacao.TabIndex = 4;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "&Multiplicação(*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(23, 82);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(100, 20);
            this.rdbSubtracao.TabIndex = 3;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "S&ubtração(-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(23, 44);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(84, 20);
            this.rdbAdicao.TabIndex = 2;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "&Adição(+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(579, 252);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(132, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(579, 321);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(132, 39);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(579, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 39);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(575, 43);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbOperadores);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblMostraResultado);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.gpbOperadores.ResumeLayout(false);
            this.gpbOperadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.Label lblMostraResultado;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
        private System.Windows.Forms.GroupBox gpbOperadores;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResultado;
    }
}