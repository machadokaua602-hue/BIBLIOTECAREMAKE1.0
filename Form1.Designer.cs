namespace BIBLIOTECAREMAKE
{
    partial class Form1
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
            this.Visualizar = new System.Windows.Forms.Panel();
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.btnUsuarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFuncionarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnHome = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpErro = new System.Windows.Forms.TabPage();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.btnStatus = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Visualizar.SuspendLayout();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Visualizar.Controls.Add(this.tcControle);
            this.Visualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visualizar.Location = new System.Drawing.Point(0, 0);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(800, 450);
            this.Visualizar.TabIndex = 0;
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.tpTelaPrincipal);
            this.tcControle.Controls.Add(this.tpErro);
            this.tcControle.Controls.Add(this.tpFuncionarios);
            this.tcControle.Controls.Add(this.tpUsuarios);
            this.tcControle.Controls.Add(this.tpLivros);
            this.tcControle.Controls.Add(this.tpStatus);
            this.tcControle.Depth = 0;
            this.tcControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControle.Location = new System.Drawing.Point(0, 0);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(800, 450);
            this.tcControle.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.Controls.Add(this.btnStatus);
            this.tpTelaPrincipal.Controls.Add(this.btnLivros);
            this.tpTelaPrincipal.Controls.Add(this.btnUsuarios);
            this.tpTelaPrincipal.Controls.Add(this.btnFuncionarios);
            this.tpTelaPrincipal.Controls.Add(this.btnHome);
            this.tpTelaPrincipal.Controls.Add(this.btnErro);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(792, 424);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            this.tpTelaPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(36, 110);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 45);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(36, 34);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(180, 45);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(676, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(117, 108);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            // 
            // btnErro
            // 
            this.btnErro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnErro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnErro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnErro.ForeColor = System.Drawing.Color.White;
            this.btnErro.Location = new System.Drawing.Point(613, 379);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(180, 45);
            this.btnErro.TabIndex = 0;
            this.btnErro.Text = "Erro";
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // tpErro
            // 
            this.tpErro.Location = new System.Drawing.Point(4, 22);
            this.tpErro.Name = "tpErro";
            this.tpErro.Padding = new System.Windows.Forms.Padding(3);
            this.tpErro.Size = new System.Drawing.Size(792, 424);
            this.tpErro.TabIndex = 1;
            this.tpErro.Text = "Erro";
            this.tpErro.UseVisualStyleBackColor = true;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(792, 424);
            this.tpFuncionarios.TabIndex = 2;
            this.tpFuncionarios.Text = "Funcionarios";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(792, 424);
            this.tpUsuarios.TabIndex = 3;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // tpLivros
            // 
            this.tpLivros.Location = new System.Drawing.Point(4, 22);
            this.tpLivros.Name = "tpLivros";
            this.tpLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivros.Size = new System.Drawing.Size(792, 424);
            this.tpLivros.TabIndex = 4;
            this.tpLivros.Text = "Livros";
            this.tpLivros.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLivros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(36, 181);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(180, 45);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = "Livros";
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // tpStatus
            // 
            this.tpStatus.Location = new System.Drawing.Point(4, 22);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatus.Size = new System.Drawing.Size(792, 424);
            this.tpStatus.TabIndex = 5;
            this.tpStatus.Text = "Status";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(36, 263);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(180, 45);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Status";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Visualizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Visualizar.ResumeLayout(false);
            this.tcControle.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Visualizar;
        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
        private System.Windows.Forms.TabPage tpErro;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnHome;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpUsuarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuarios;
        private System.Windows.Forms.TabPage tpLivros;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private System.Windows.Forms.TabPage tpStatus;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStatus;
    }
}

