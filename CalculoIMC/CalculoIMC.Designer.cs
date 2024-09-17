
namespace CalculoIMC
{
    partial class CalculoIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoIMC));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.gpbTabela = new System.Windows.Forms.GroupBox();
            this.ptbTabela = new System.Windows.Forms.PictureBox();
            this.lblMostraIMC = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblMostraClass = new System.Windows.Forms.Label();
            this.lblMostraObe = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblObe = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(73, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 37);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular >";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(206, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 37);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar >";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAltura.Location = new System.Drawing.Point(73, 37);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 16);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // gpbTabela
            // 
            this.gpbTabela.BackColor = System.Drawing.SystemColors.Control;
            this.gpbTabela.Controls.Add(this.ptbTabela);
            this.gpbTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTabela.Location = new System.Drawing.Point(34, 275);
            this.gpbTabela.Name = "gpbTabela";
            this.gpbTabela.Size = new System.Drawing.Size(589, 237);
            this.gpbTabela.TabIndex = 3;
            this.gpbTabela.TabStop = false;
            this.gpbTabela.Text = "Veja a Interpretação Do IMC";
            // 
            // ptbTabela
            // 
            this.ptbTabela.Image = ((System.Drawing.Image)(resources.GetObject("ptbTabela.Image")));
            this.ptbTabela.Location = new System.Drawing.Point(0, 24);
            this.ptbTabela.Name = "ptbTabela";
            this.ptbTabela.Size = new System.Drawing.Size(591, 213);
            this.ptbTabela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbTabela.TabIndex = 18;
            this.ptbTabela.TabStop = false;
            // 
            // lblMostraIMC
            // 
            this.lblMostraIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraIMC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraIMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraIMC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMostraIMC.Location = new System.Drawing.Point(390, 98);
            this.lblMostraIMC.Name = "lblMostraIMC";
            this.lblMostraIMC.Size = new System.Drawing.Size(70, 40);
            this.lblMostraIMC.TabIndex = 4;
            this.lblMostraIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(73, 62);
            this.txtAltura.MaxLength = 5;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(203, 62);
            this.txtPeso.MaxLength = 5;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(107, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeso.Location = new System.Drawing.Point(203, 37);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(48, 16);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // lblMostraClass
            // 
            this.lblMostraClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMostraClass.Location = new System.Drawing.Point(509, 98);
            this.lblMostraClass.Name = "lblMostraClass";
            this.lblMostraClass.Size = new System.Drawing.Size(103, 40);
            this.lblMostraClass.TabIndex = 8;
            this.lblMostraClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMostraObe
            // 
            this.lblMostraObe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMostraObe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraObe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMostraObe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraObe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMostraObe.Location = new System.Drawing.Point(678, 98);
            this.lblMostraObe.Name = "lblMostraObe";
            this.lblMostraObe.Size = new System.Drawing.Size(58, 40);
            this.lblMostraObe.TabIndex = 9;
            this.lblMostraObe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIMC.Location = new System.Drawing.Point(407, 66);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(42, 16);
            this.lblIMC.TabIndex = 10;
            this.lblIMC.Text = "IMC :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClass.Location = new System.Drawing.Point(506, 66);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(106, 16);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "Classificação:";
            // 
            // lblObe
            // 
            this.lblObe.AutoSize = true;
            this.lblObe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObe.Location = new System.Drawing.Point(651, 66);
            this.lblObe.Name = "lblObe";
            this.lblObe.Size = new System.Drawing.Size(130, 16);
            this.lblObe.TabIndex = 12;
            this.lblObe.Text = "Obesidade(grau):";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(678, 421);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 65);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(678, 323);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 65);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblObe);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblMostraObe);
            this.Controls.Add(this.lblMostraClass);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblMostraIMC);
            this.Controls.Add(this.gpbTabela);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculoIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoIMC";
            this.Load += new System.EventHandler(this.CalculoIMC_Load);
            this.gpbTabela.ResumeLayout(false);
            this.gpbTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.GroupBox gpbTabela;
        private System.Windows.Forms.Label lblMostraIMC;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.PictureBox ptbTabela;
        private System.Windows.Forms.Label lblMostraClass;
        private System.Windows.Forms.Label lblMostraObe;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblObe;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
    }
}