using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECAREMAKE
{
    public partial class Form1 : Form
    {
        private Erros erros;
        private Funcionarios funcionarios;
        private Usuarios usuarios;
        private Livros livros;
        private Status status;
        public Form1()
        {
            InitializeComponent();
            erros = new Erros();
            erros.Dock = DockStyle.Fill;
            tpErro.Controls.Add(erros);
            erros.Controls.Find("btnErro", true).First().Click += VoltarTelaPrincipal;
            //localiza o botao btnErro, verifica se existe

            funcionarios = new Funcionarios();
            funcionarios.Dock = DockStyle.Fill;
            tpFuncionarios.Controls.Add(funcionarios);
            funcionarios.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;

           usuarios = new Usuarios();
           usuarios.Dock = DockStyle.Fill;
           tpUsuarios.Controls.Add(usuarios);
           usuarios.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;

            livros = new Livros();
            livros.Dock = DockStyle.Fill;
            tpLivros.Controls.Add(livros);
            livros.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;

            status = new Status();
            status.Dock = DockStyle.Fill;
            tpStatus.Controls.Add(status);
            status.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;
        }
        
        private void VoltarTelaPrincipal(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpTelaPrincipal);
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            erros.Dispose();
            erros = null;
            tpErro.Controls.Clear();
            erros = new Erros();
            erros.Controls.Find("btnErro", true).First().Click += VoltarTelaPrincipal;
            tpErro.Controls.Add(erros);
            tcControle.SelectTab(tpErro);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
                funcionarios.Dispose();
                funcionarios = null;
                tpFuncionarios.Controls.Clear();
                funcionarios = new Funcionarios();
                funcionarios.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;
                tpFuncionarios.Controls.Add(funcionarios);
            tcControle.SelectTab(tpFuncionarios);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            usuarios.Dispose();
            usuarios = null;
            tpUsuarios.Controls.Clear();
            usuarios = new Usuarios();
            usuarios.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;
            tpUsuarios.Controls.Add(usuarios);
            tcControle.SelectTab(tpUsuarios);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            
            livros.Dispose();
            livros = null;
            tpLivros.Controls.Clear();
            livros = new Livros();
            livros.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;
            tpLivros.Controls.Add(livros);
            tcControle.SelectTab(tpLivros);


        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            status.Dispose();
            status = null;
            tpStatus.Controls.Clear();
            status = new Status();
            status.Controls.Find("btnHome", true).First().Click += VoltarTelaPrincipal;
            tpStatus.Controls.Add(status);
            tcControle.SelectTab(tpStatus);
        }
    }
}
