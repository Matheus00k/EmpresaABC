
namespace CalculoIMC
{
    partial class frmConversãodeMoedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversãodeMoedas));
            this.txtReal = new System.Windows.Forms.TextBox();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbPeso = new System.Windows.Forms.RadioButton();
            this.rdbIene = new System.Windows.Forms.RadioButton();
            this.lblReal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMostraResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblMostraMoeda = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(96, 144);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(95, 20);
            this.txtReal.TabIndex = 0;
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Location = new System.Drawing.Point(41, 21);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(59, 20);
            this.rdbDolar.TabIndex = 2;
            this.rdbDolar.TabStop = true;
            this.rdbDolar.Text = "Dólar";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(41, 65);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(54, 20);
            this.rdbEuro.TabIndex = 3;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbPeso
            // 
            this.rdbPeso.AutoSize = true;
            this.rdbPeso.Location = new System.Drawing.Point(41, 114);
            this.rdbPeso.Name = "rdbPeso";
            this.rdbPeso.Size = new System.Drawing.Size(58, 20);
            this.rdbPeso.TabIndex = 4;
            this.rdbPeso.TabStop = true;
            this.rdbPeso.Text = "Peso";
            this.rdbPeso.UseVisualStyleBackColor = true;
            // 
            // rdbIene
            // 
            this.rdbIene.AutoSize = true;
            this.rdbIene.Location = new System.Drawing.Point(41, 152);
            this.rdbIene.Name = "rdbIene";
            this.rdbIene.Size = new System.Drawing.Size(52, 20);
            this.rdbIene.TabIndex = 5;
            this.rdbIene.TabStop = true;
            this.rdbIene.Text = "Iene";
            this.rdbIene.UseVisualStyleBackColor = true;
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(92, 103);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(81, 20);
            this.lblReal.TabIndex = 6;
            this.lblReal.Text = "Reais(R$)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIene);
            this.groupBox1.Controls.Add(this.rdbPeso);
            this.groupBox1.Controls.Add(this.rdbEuro);
            this.groupBox1.Controls.Add(this.rdbDolar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblMostraResultado
            // 
            this.lblMostraResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMostraResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraResultado.Location = new System.Drawing.Point(589, 153);
            this.lblMostraResultado.Name = "lblMostraResultado";
            this.lblMostraResultado.Size = new System.Drawing.Size(101, 40);
            this.lblMostraResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(585, 119);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 20);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gray;
            this.btnVoltar.Location = new System.Drawing.Point(589, 318);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(89, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 39);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(256, 318);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 39);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "&Lmipar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblMostraMoeda
            // 
            this.lblMostraMoeda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMostraMoeda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraMoeda.Location = new System.Drawing.Point(589, 244);
            this.lblMostraMoeda.Name = "lblMostraMoeda";
            this.lblMostraMoeda.Size = new System.Drawing.Size(101, 40);
            this.lblMostraMoeda.TabIndex = 14;
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeda.Location = new System.Drawing.Point(585, 215);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(68, 20);
            this.lblMoeda.TabIndex = 15;
            this.lblMoeda.Text = "Moeda:";
            // 
            // frmConversãodeMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblMostraMoeda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMostraResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.txtReal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConversãodeMoedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de Moedas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbPeso;
        private System.Windows.Forms.RadioButton rdbIene;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMostraResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMostraMoeda;
        private System.Windows.Forms.Label lblMoeda;
    }
}