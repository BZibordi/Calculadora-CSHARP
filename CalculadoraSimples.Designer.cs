
namespace calculadora
{
    partial class frmcalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.grpoperacao = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnmedia = new System.Windows.Forms.Button();
            this.bntdivisao = new System.Windows.Forms.Button();
            this.bntmulti = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpoperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // nblnum1
            // 
            this.nblnum1.AutoSize = true;
            this.nblnum1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.nblnum1.Location = new System.Drawing.Point(72, 123);
            this.nblnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nblnum1.Name = "nblnum1";
            this.nblnum1.Size = new System.Drawing.Size(143, 33);
            this.nblnum1.TabIndex = 0;
            this.nblnum1.Text = "Número 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblnum2.Location = new System.Drawing.Point(386, 123);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(143, 33);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Número 2";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblresultado.Location = new System.Drawing.Point(688, 123);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(146, 33);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "Resultado";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtnum1.Location = new System.Drawing.Point(70, 174);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(145, 45);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtnum2.Location = new System.Drawing.Point(384, 174);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(145, 45);
            this.txtnum2.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtresult.Location = new System.Drawing.Point(686, 174);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(148, 45);
            this.txtresult.TabIndex = 5;
            // 
            // grpoperacao
            // 
            this.grpoperacao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpoperacao.Controls.Add(this.btnLimpar);
            this.grpoperacao.Controls.Add(this.btnmedia);
            this.grpoperacao.Controls.Add(this.bntdivisao);
            this.grpoperacao.Controls.Add(this.bntmulti);
            this.grpoperacao.Controls.Add(this.btnsub);
            this.grpoperacao.Controls.Add(this.btnsoma);
            this.grpoperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grpoperacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpoperacao.Location = new System.Drawing.Point(32, 271);
            this.grpoperacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpoperacao.Name = "grpoperacao";
            this.grpoperacao.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpoperacao.Size = new System.Drawing.Size(852, 229);
            this.grpoperacao.TabIndex = 6;
            this.grpoperacao.TabStop = false;
            this.grpoperacao.Text = "Operações";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLimpar.Location = new System.Drawing.Point(747, 0);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 62);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnmedia
            // 
            this.btnmedia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnmedia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnmedia.Location = new System.Drawing.Point(415, 81);
            this.btnmedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(141, 78);
            this.btnmedia.TabIndex = 4;
            this.btnmedia.Text = "Média";
            this.btnmedia.UseVisualStyleBackColor = false;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // bntdivisao
            // 
            this.bntdivisao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntdivisao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntdivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntdivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bntdivisao.Location = new System.Drawing.Point(229, 131);
            this.bntdivisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntdivisao.Name = "bntdivisao";
            this.bntdivisao.Size = new System.Drawing.Size(141, 78);
            this.bntdivisao.TabIndex = 3;
            this.bntdivisao.Text = "Divisão";
            this.bntdivisao.UseVisualStyleBackColor = false;
            this.bntdivisao.Click += new System.EventHandler(this.bntdivisao_Click);
            // 
            // bntmulti
            // 
            this.bntmulti.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntmulti.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntmulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntmulti.Location = new System.Drawing.Point(38, 131);
            this.bntmulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntmulti.Name = "bntmulti";
            this.bntmulti.Size = new System.Drawing.Size(141, 78);
            this.bntmulti.TabIndex = 2;
            this.bntmulti.Text = "Multiplicação";
            this.bntmulti.UseVisualStyleBackColor = false;
            this.bntmulti.Click += new System.EventHandler(this.bntmulti_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnsub.Location = new System.Drawing.Point(229, 37);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(141, 78);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "Subtração";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsoma.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnsoma.Location = new System.Drawing.Point(38, 37);
            this.btnsoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(141, 78);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbloperacao.Location = new System.Drawing.Point(280, 171);
            this.lbloperacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(45, 48);
            this.lbloperacao.TabIndex = 7;
            this.lbloperacao.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(591, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calculadora Simples";
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.grpoperacao);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.nblnum1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmcalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmcalculadora_Load);
            this.grpoperacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.GroupBox grpoperacao;
        private System.Windows.Forms.Button bntdivisao;
        private System.Windows.Forms.Button bntmulti;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

