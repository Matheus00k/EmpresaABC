
namespace CalculoIMC
{
    partial class frmCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombustivel));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblMostraConsumo = new System.Windows.Forms.Label();
            this.lblMostraResultado = new System.Windows.Forms.Label();
            this.lblMostraKM = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(592, 462);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 45);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(55, 100);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(201, 20);
            this.txtDistancia.TabIndex = 0;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(55, 158);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(201, 20);
            this.txtConsumo.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(55, 217);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(201, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // lblMostraConsumo
            // 
            this.lblMostraConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraConsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraConsumo.Location = new System.Drawing.Point(365, 391);
            this.lblMostraConsumo.Name = "lblMostraConsumo";
            this.lblMostraConsumo.Size = new System.Drawing.Size(103, 33);
            this.lblMostraConsumo.TabIndex = 7;
            this.lblMostraConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostraResultado
            // 
            this.lblMostraResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraResultado.Location = new System.Drawing.Point(607, 391);
            this.lblMostraResultado.Name = "lblMostraResultado";
            this.lblMostraResultado.Size = new System.Drawing.Size(103, 33);
            this.lblMostraResultado.TabIndex = 8;
            this.lblMostraResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostraKM
            // 
            this.lblMostraKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraKM.Location = new System.Drawing.Point(103, 391);
            this.lblMostraKM.Name = "lblMostraKM";
            this.lblMostraKM.Size = new System.Drawing.Size(103, 33);
            this.lblMostraKM.TabIndex = 9;
            this.lblMostraKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(55, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 49);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(170, 254);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 49);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDistancia.Location = new System.Drawing.Point(52, 59);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(305, 20);
            this.lblDistancia.TabIndex = 12;
            this.lblDistancia.Text = "Insira a distância que irá percorrer em km*";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreco.Location = new System.Drawing.Point(52, 194);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(462, 20);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Adicione o preço do combustível onde você abastece ( ex: 4,15)*";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKM.Location = new System.Drawing.Point(60, 353);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(196, 20);
            this.lblKM.TabIndex = 15;
            this.lblKM.Text = "Quilometragem percorrida:";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCombustivel.Location = new System.Drawing.Point(293, 353);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(242, 20);
            this.lblCombustivel.TabIndex = 16;
            this.lblCombustivel.Text = "Consumo por litro de combustível";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(574, 353);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(204, 20);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Resultado (Preço Total):";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConsumo.Location = new System.Drawing.Point(52, 132);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(266, 20);
            this.lblConsumo.TabIndex = 13;
            this.lblConsumo.Text = "Insira o consumo do veículo por litro*";
            // 
            // frmCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMostraKM);
            this.Controls.Add(this.lblMostraResultado);
            this.Controls.Add(this.lblMostraConsumo);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustivel";
            this.Load += new System.EventHandler(this.frmCombustivel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblMostraConsumo;
        private System.Windows.Forms.Label lblMostraResultado;
        private System.Windows.Forms.Label lblMostraKM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConsumo;
    }
}