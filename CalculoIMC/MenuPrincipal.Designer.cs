
namespace CalculoIMC
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnCombustivel = new System.Windows.Forms.Button();
            this.btnFP = new System.Windows.Forms.Button();
            this.btnTF = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIMC.Image = ((System.Drawing.Image)(resources.GetObject("btnIMC.Image")));
            this.btnIMC.Location = new System.Drawing.Point(46, 35);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(134, 192);
            this.btnIMC.TabIndex = 0;
            this.btnIMC.Text = "&Calculadora de IMC";
            this.btnIMC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIMC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // btnCombustivel
            // 
            this.btnCombustivel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCombustivel.Image = ((System.Drawing.Image)(resources.GetObject("btnCombustivel.Image")));
            this.btnCombustivel.Location = new System.Drawing.Point(282, 35);
            this.btnCombustivel.Name = "btnCombustivel";
            this.btnCombustivel.Size = new System.Drawing.Size(134, 192);
            this.btnCombustivel.TabIndex = 1;
            this.btnCombustivel.Text = "C&alculadora de Combustivel";
            this.btnCombustivel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCombustivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCombustivel.UseVisualStyleBackColor = false;
            this.btnCombustivel.Click += new System.EventHandler(this.btnCombustivel_Click);
            // 
            // btnFP
            // 
            this.btnFP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFP.Image = ((System.Drawing.Image)(resources.GetObject("btnFP.Image")));
            this.btnFP.Location = new System.Drawing.Point(508, 35);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(134, 192);
            this.btnFP.TabIndex = 2;
            this.btnFP.Text = "&Folha de Pagamento";
            this.btnFP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFP.UseVisualStyleBackColor = false;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // btnTF
            // 
            this.btnTF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTF.Image = ((System.Drawing.Image)(resources.GetObject("btnTF.Image")));
            this.btnTF.Location = new System.Drawing.Point(46, 307);
            this.btnTF.Name = "btnTF";
            this.btnTF.Size = new System.Drawing.Size(134, 192);
            this.btnTF.TabIndex = 3;
            this.btnTF.Text = "&Taxa de Frequência";
            this.btnTF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTF.UseVisualStyleBackColor = false;
            this.btnTF.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCM
            // 
            this.btnCM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCM.Image = ((System.Drawing.Image)(resources.GetObject("btnCM.Image")));
            this.btnCM.Location = new System.Drawing.Point(282, 307);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(134, 192);
            this.btnCM.TabIndex = 4;
            this.btnCM.Text = "C&onversor de Moedas";
            this.btnCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCM.UseVisualStyleBackColor = false;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // btnCA
            // 
            this.btnCA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCA.Image = ((System.Drawing.Image)(resources.GetObject("btnCA.Image")));
            this.btnCA.Location = new System.Drawing.Point(508, 307);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(134, 192);
            this.btnCA.TabIndex = 5;
            this.btnCA.Text = "Calc&ulo de Consumo de Água";
            this.btnCA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCA.UseVisualStyleBackColor = false;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(690, 228);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 105);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.btnCM);
            this.Controls.Add(this.btnTF);
            this.Controls.Add(this.btnFP);
            this.Controls.Add(this.btnCombustivel);
            this.Controls.Add(this.btnIMC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnCombustivel;
        private System.Windows.Forms.Button btnFP;
        private System.Windows.Forms.Button btnTF;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Button btnSair;
    }
}