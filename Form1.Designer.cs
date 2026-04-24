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
            this.siticoneCustomGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFuncionarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnStatus = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnUsuarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpErro = new System.Windows.Forms.TabPage();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.tcEmprestimo = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.tpEmprestar = new System.Windows.Forms.TabPage();
            this.tpDevolver = new System.Windows.Forms.TabPage();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.Visualizar.SuspendLayout();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.siticoneCustomGradientPanel2.SuspendLayout();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.tpStatus.SuspendLayout();
            this.tcEmprestimo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tpTelaPrincipal.Controls.Add(this.siticoneCustomGradientPanel2);
            this.tpTelaPrincipal.Controls.Add(this.siticoneCustomGradientPanel1);
            this.tpTelaPrincipal.Controls.Add(this.btnErro);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(792, 424);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            this.tpTelaPrincipal.UseVisualStyleBackColor = true;
            // 
            // siticoneCustomGradientPanel2
            // 
            this.siticoneCustomGradientPanel2.Controls.Add(this.label1);
            this.siticoneCustomGradientPanel2.Controls.Add(this.btnHome);
            this.siticoneCustomGradientPanel2.FillColor = System.Drawing.Color.Peru;
            this.siticoneCustomGradientPanel2.Location = new System.Drawing.Point(0, -19);
            this.siticoneCustomGradientPanel2.Name = "siticoneCustomGradientPanel2";
            this.siticoneCustomGradientPanel2.Size = new System.Drawing.Size(793, 106);
            this.siticoneCustomGradientPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livraria";
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(693, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(91, 81);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.btnLivros);
            this.siticoneCustomGradientPanel1.Controls.Add(this.btnFuncionarios);
            this.siticoneCustomGradientPanel1.Controls.Add(this.btnStatus);
            this.siticoneCustomGradientPanel1.Controls.Add(this.btnUsuarios);
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(3, 93);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(219, 335);
            this.siticoneCustomGradientPanel1.TabIndex = 6;
            // 
            // btnLivros
            // 
            this.btnLivros.BorderThickness = 2;
            this.btnLivros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLivros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLivros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLivros.ForeColor = System.Drawing.Color.Black;
            this.btnLivros.Location = new System.Drawing.Point(0, 82);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(217, 76);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = "Livros";
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BorderThickness = 2;
            this.btnFuncionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(217, 76);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BorderThickness = 2;
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.Black;
            this.btnStatus.Location = new System.Drawing.Point(0, 164);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(217, 77);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Status";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BorderThickness = 2;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 247);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(217, 76);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnErro
            // 
            this.btnErro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnErro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnErro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // tpStatus
            // 
            this.tpStatus.Controls.Add(this.tableLayoutPanel1);
            this.tpStatus.Location = new System.Drawing.Point(4, 22);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatus.Size = new System.Drawing.Size(792, 424);
            this.tpStatus.TabIndex = 5;
            this.tpStatus.Text = "Status";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // tcEmprestimo
            // 
            this.tcEmprestimo.Controls.Add(this.tpPrincipal);
            this.tcEmprestimo.Controls.Add(this.tpEmprestar);
            this.tcEmprestimo.Controls.Add(this.tpDevolver);
            this.tcEmprestimo.Controls.Add(this.tpConsultar);
            this.tcEmprestimo.Depth = 0;
            this.tcEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmprestimo.Location = new System.Drawing.Point(3, 46);
            this.tcEmprestimo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcEmprestimo.Name = "tcEmprestimo";
            this.tcEmprestimo.SelectedIndex = 0;
            this.tcEmprestimo.Size = new System.Drawing.Size(784, 361);
            this.tcEmprestimo.TabIndex = 0;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(785, 398);
            this.tpPrincipal.TabIndex = 0;
            this.tpPrincipal.Text = "Principal";
            this.tpPrincipal.UseVisualStyleBackColor = true;
            // 
            // tpEmprestar
            // 
            this.tpEmprestar.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestar.Name = "tpEmprestar";
            this.tpEmprestar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestar.Size = new System.Drawing.Size(785, 398);
            this.tpEmprestar.TabIndex = 1;
            this.tpEmprestar.Text = "Emprestar";
            this.tpEmprestar.UseVisualStyleBackColor = true;
            // 
            // tpDevolver
            // 
            this.tpDevolver.Location = new System.Drawing.Point(4, 22);
            this.tpDevolver.Name = "tpDevolver";
            this.tpDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolver.Size = new System.Drawing.Size(785, 398);
            this.tpDevolver.TabIndex = 2;
            this.tpDevolver.Text = "Devolver";
            this.tpDevolver.UseVisualStyleBackColor = true;
            // 
            // tpConsultar
            // 
            this.tpConsultar.BackColor = System.Drawing.Color.Black;
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultar.Size = new System.Drawing.Size(776, 335);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tcEmprestimo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.51219F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 410);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnDevolver, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmprestar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConsultar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelecionar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 37);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Black;
            this.btnSelecionar.ForeColor = System.Drawing.Color.Orange;
            this.btnSelecionar.Location = new System.Drawing.Point(3, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(190, 31);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.ForeColor = System.Drawing.Color.Orange;
            this.btnConsultar.Location = new System.Drawing.Point(199, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(190, 31);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.Black;
            this.btnEmprestar.ForeColor = System.Drawing.Color.Orange;
            this.btnEmprestar.Location = new System.Drawing.Point(395, 3);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(190, 31);
            this.btnEmprestar.TabIndex = 2;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Black;
            this.btnDevolver.ForeColor = System.Drawing.Color.Orange;
            this.btnDevolver.Location = new System.Drawing.Point(591, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(190, 31);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
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
            this.siticoneCustomGradientPanel2.ResumeLayout(false);
            this.siticoneCustomGradientPanel2.PerformLayout();
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.tpStatus.ResumeLayout(false);
            this.tcEmprestimo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Visualizar;
        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
        private System.Windows.Forms.TabPage tpErro;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpUsuarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuarios;
        private System.Windows.Forms.TabPage tpLivros;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private System.Windows.Forms.TabPage tpStatus;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStatus;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnHome;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl tcEmprestimo;
        private System.Windows.Forms.TabPage tpPrincipal;
        private System.Windows.Forms.TabPage tpEmprestar;
        private System.Windows.Forms.TabPage tpDevolver;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSelecionar;
    }
}

