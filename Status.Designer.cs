namespace BIBLIOTECAREMAKE
{
    partial class Status
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHome = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.lboUsuario = new System.Windows.Forms.ListBox();
            this.cboDados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(724, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(96, 81);
            this.btnHome.TabIndex = 34;
            this.btnHome.Text = "Home";
            // 
            // lboLivros
            // 
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(109, 173);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(271, 121);
            this.lboLivros.TabIndex = 35;
            // 
            // lboUsuario
            // 
            this.lboUsuario.FormattingEnabled = true;
            this.lboUsuario.Location = new System.Drawing.Point(417, 173);
            this.lboUsuario.Name = "lboUsuario";
            this.lboUsuario.Size = new System.Drawing.Size(271, 121);
            this.lboUsuario.TabIndex = 36;
            // 
            // cboDados
            // 
            this.cboDados.FormattingEnabled = true;
            this.cboDados.Location = new System.Drawing.Point(109, 63);
            this.cboDados.Name = "cboDados";
            this.cboDados.Size = new System.Drawing.Size(579, 21);
            this.cboDados.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Selecione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Digite um livro pra consultar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Digite o nome do cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 43;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(339, 383);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(124, 38);
            this.btnStatus.TabIndex = 44;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDados);
            this.Controls.Add(this.lboUsuario);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.btnHome);
            this.Name = "Status";
            this.Size = new System.Drawing.Size(841, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnHome;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.ListBox lboUsuario;
        private System.Windows.Forms.ComboBox cboDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnStatus;
    }
}
