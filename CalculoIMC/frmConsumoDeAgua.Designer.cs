
namespace CalculoIMC
{
    partial class frmConsumoDeAgua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumoDeAgua));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblmetros3 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lblMostraValor = new System.Windows.Forms.Label();
            this.lblMostraConsumoDiario = new System.Windows.Forms.Label();
            this.lblpagar = new System.Windows.Forms.Label();
            this.lblAgua = new System.Windows.Forms.Label();
            this.lblCubicos = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btnCalcularAgua = new System.Windows.Forms.Button();
            this.gpbDiario = new System.Windows.Forms.GroupBox();
            this.gpbSabesp = new System.Windows.Forms.GroupBox();
            this.gpbDiario.SuspendLayout();
            this.gpbSabesp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.Location = new System.Drawing.Point(25, 267);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "&Calccular:";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Location = new System.Drawing.Point(228, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "&Limpar:";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Location = new System.Drawing.Point(666, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 40);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "&Voltar:";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(25, 49);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(106, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(33, 50);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(106, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(33, 111);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(106, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // lblmetros3
            // 
            this.lblmetros3.AutoSize = true;
            this.lblmetros3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmetros3.Location = new System.Drawing.Point(21, 12);
            this.lblmetros3.Name = "lblmetros3";
            this.lblmetros3.Size = new System.Drawing.Size(129, 20);
            this.lblmetros3.TabIndex = 6;
            this.lblmetros3.Text = "Consumo em m³:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(29, 13);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 20);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso: ";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(29, 88);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(54, 20);
            this.lbPeso.TabIndex = 8;
            this.lbPeso.Text = "Idade:";
            // 
            // lblMostraValor
            // 
            this.lblMostraValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMostraValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraValor.Location = new System.Drawing.Point(25, 211);
            this.lblMostraValor.Name = "lblMostraValor";
            this.lblMostraValor.Size = new System.Drawing.Size(77, 33);
            this.lblMostraValor.TabIndex = 9;
            this.lblMostraValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostraConsumoDiario
            // 
            this.lblMostraConsumoDiario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMostraConsumoDiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraConsumoDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraConsumoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraConsumoDiario.Location = new System.Drawing.Point(33, 211);
            this.lblMostraConsumoDiario.Name = "lblMostraConsumoDiario";
            this.lblMostraConsumoDiario.Size = new System.Drawing.Size(77, 33);
            this.lblMostraConsumoDiario.TabIndex = 10;
            this.lblMostraConsumoDiario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpagar
            // 
            this.lblpagar.AutoSize = true;
            this.lblpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagar.Location = new System.Drawing.Point(21, 181);
            this.lblpagar.Name = "lblpagar";
            this.lblpagar.Size = new System.Drawing.Size(109, 20);
            this.lblpagar.TabIndex = 11;
            this.lblpagar.Text = "Valor a Pagar:";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.Location = new System.Drawing.Point(29, 182);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(187, 20);
            this.lblAgua.TabIndex = 12;
            this.lblAgua.Text = "Consumo diário de Água:";
            // 
            // lblCubicos
            // 
            this.lblCubicos.AutoSize = true;
            this.lblCubicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCubicos.Location = new System.Drawing.Point(21, 87);
            this.lblCubicos.Name = "lblCubicos";
            this.lblCubicos.Size = new System.Drawing.Size(142, 20);
            this.lblCubicos.TabIndex = 14;
            this.lblCubicos.Text = "Valor a cada 10m³:";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(25, 124);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(106, 20);
            this.txtMetros.TabIndex = 13;
            // 
            // btnCalcularAgua
            // 
            this.btnCalcularAgua.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalcularAgua.Location = new System.Drawing.Point(33, 268);
            this.btnCalcularAgua.Name = "btnCalcularAgua";
            this.btnCalcularAgua.Size = new System.Drawing.Size(93, 40);
            this.btnCalcularAgua.TabIndex = 15;
            this.btnCalcularAgua.Text = "C&alccular:";
            this.btnCalcularAgua.UseVisualStyleBackColor = false;
            this.btnCalcularAgua.Click += new System.EventHandler(this.btnCalcularAgua_Click);
            // 
            // gpbDiario
            // 
            this.gpbDiario.Controls.Add(this.btnCalcularAgua);
            this.gpbDiario.Controls.Add(this.lblAgua);
            this.gpbDiario.Controls.Add(this.lblMostraConsumoDiario);
            this.gpbDiario.Controls.Add(this.lbPeso);
            this.gpbDiario.Controls.Add(this.lblPeso);
            this.gpbDiario.Controls.Add(this.txtIdade);
            this.gpbDiario.Controls.Add(this.txtPeso);
            this.gpbDiario.Location = new System.Drawing.Point(388, 23);
            this.gpbDiario.Name = "gpbDiario";
            this.gpbDiario.Size = new System.Drawing.Size(242, 334);
            this.gpbDiario.TabIndex = 16;
            this.gpbDiario.TabStop = false;
            this.gpbDiario.Text = "Consumo Diário";
            // 
            // gpbSabesp
            // 
            this.gpbSabesp.Controls.Add(this.lblCubicos);
            this.gpbSabesp.Controls.Add(this.txtMetros);
            this.gpbSabesp.Controls.Add(this.lblpagar);
            this.gpbSabesp.Controls.Add(this.lblMostraValor);
            this.gpbSabesp.Controls.Add(this.lblmetros3);
            this.gpbSabesp.Controls.Add(this.txtConsumo);
            this.gpbSabesp.Controls.Add(this.btnCalcular);
            this.gpbSabesp.Location = new System.Drawing.Point(29, 23);
            this.gpbSabesp.Name = "gpbSabesp";
            this.gpbSabesp.Size = new System.Drawing.Size(237, 334);
            this.gpbSabesp.TabIndex = 17;
            this.gpbSabesp.TabStop = false;
            this.gpbSabesp.Text = "Consumo Sabesb:";
            // 
            // frmConsumoDeAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbSabesp);
            this.Controls.Add(this.gpbDiario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsumoDeAgua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Consumo De Água";
            this.Load += new System.EventHandler(this.frmConsumoDeAgua_Load);
            this.gpbDiario.ResumeLayout(false);
            this.gpbDiario.PerformLayout();
            this.gpbSabesp.ResumeLayout(false);
            this.gpbSabesp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblmetros3;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lblMostraValor;
        private System.Windows.Forms.Label lblMostraConsumoDiario;
        private System.Windows.Forms.Label lblpagar;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.Label lblCubicos;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Button btnCalcularAgua;
        private System.Windows.Forms.GroupBox gpbDiario;
        private System.Windows.Forms.GroupBox gpbSabesp;
    }
}