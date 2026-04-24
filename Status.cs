using BIBLIOTECAREMAKE.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BIBLIOTECAREMAKE.BibliotecaDBDataSet;

namespace BIBLIOTECAREMAKE
{
    public partial class Status : UserControl
    {
        public Status()

        {

            //sera removido no futuro
            InitializeComponent();
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var obterFuncionarios = from linha in funcionarios.GetData() select linha;
            foreach (var funcionario in obterFuncionarios) cboDados.Items.Add(funcionario);
            cboDados.SelectedIndex = 0;
            //Ate aqui 
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var obterLivros = from linha in livros.GetData()
                              where linha.QuantidadeDisponivel > 0
                              select linha;
            foreach (var livro in obterLivros) lboLivros.Items.Add(livro);
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var obterUsuarios = from linha in usuarios.GetData()
                                select linha;
            foreach (var usuario in obterUsuarios) lboUsuario.Items.Add(usuario);

        }


        public void ObterFuncionariosFunc()
        {
            FuncionariosTableAdapter FuncionariosSelecionado = new FuncionariosTableAdapter();
            var dados = from linha in FuncionariosSelecionado.GetData() select linha;
            foreach (var funcionario in dados) cboDados.Items.Add(funcionario);
            cboDados.SelectedIndex = 0;
        }
        public void obtenhaLivros()
        {
            LivrosTableAdapter LivrosSelecionado = new LivrosTableAdapter();
            var dados = from linha in LivrosSelecionado.GetData() select linha;
            foreach (var livro in dados) cboDados.Items.Add(livro);
            cboDados.SelectedIndex = 0;
        }

        public void obtenhaUsuarios()
        {
            UsuariosTableAdapter UsuarioDados = new UsuariosTableAdapter();
            var dados = from linha in UsuarioDados.GetData() select linha;
            foreach (var cliente in dados) lboLivros.Items.Add(cliente);
            lboLivros.SelectedIndex = 0;
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            LivrosRow Livroselecionado = cboDados.SelectedItem as LivrosRow;
            UsuariosRow UsuarioSelecionado = cboDados.SelectedItem as UsuariosRow;
            FuncionariosRow funcionarioSelecionado = cboDados.SelectedItem as FuncionariosRow;
            if(UsuarioSelecionado == null) return;
            else if(Livroselecionado == null) return;
            else if(funcionarioSelecionado == null) return;
            
            QueriesTableAdapter consulta = new QueriesTableAdapter();

            consulta.EmprestarLivro(
            Livroselecionado.LivroID,
            funcionarioSelecionado.FuncionarioID,
            UsuarioSelecionado.UsuarioID
            );
             MessageBox.Show("Livro emprestado com sucesso!");

        }
    }
}
