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

namespace BIBLIOTECAREMAKE
{
    public partial class Consulta : UserControl
    {
        public Consulta()
        {
            InitializeComponent();
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboConsulta.Items.AddRange(requisicoes.GetData().ToArray());

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void lboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesROW requisicoes = lboConsulta.SelectedItem as RequisicoesROW;
            lblDataDeStatus.Text = requisicoes.DataDeStatus.ToString();
            lblDataDevolucao.Text = requisicoes.DataDevolucao;
            lblEstatus.Text = requisicoes.Estatus;
            LivrosTableAdapter livros = new LivrosTableAdapter();
            LirosROW livro = (from linha in livros.GetData()
                            where linha.LivroID == requisicoes.LivroID
                            select linha).FirstOrDefault();
            if (livro != null) return;
            lblTitulo.Text = livro.Titulo;

            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            FuncionarioRow funcionario = (from linha in funcionarios.GetData()
                            where linha.FuncionarioID == requisicoes.FuncionarioID
                            select linha).FirstOrDefault();
            if (funcionario != null) return;
            lblFuncionario.Text = funcionario.NomeCompleto;
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            UsuarioRow usuario = (from linha in usuarios.GetData()
                            where linha.UsuarioID == requisicoes.UsuarioID
                            select linha).FirstOrDefault();
            if (usuario != null) return;
         
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
                lboConsulta.Items.AddRange(dados.GetData().ToArray());
                return;
            }
            RequisicoesTableAdapter dados = new RequisicoesTableAdapter();
            lboConsulta.Items.Clear();
            lboConsulta.Items.AddRange((from linha in requisicoes.GetData()
                                        where requisicoes.ToString().Contains(textBox1.Text)
                                        select linha).ToArray());

        }
    }
}
