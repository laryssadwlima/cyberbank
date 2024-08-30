using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyberbank
{
    public partial class TelaExtrato : Form
    {
        public TelaExtrato()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //botao voltar para tela de navegação
            this.Hide();
            TelaNavegacao telaNavegacao = new TelaNavegacao();
            telaNavegacao.Show();
        }

        private void TelaExtrato_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();



            //GRID DE SAQUE
            dataGridView1.Rows.Clear();
            dataGridView1.ClearSelection();
            try
            {
                // Query SQL para buscar movimentações
                string sql = $"SELECT valor, dataTransacao FROM Movimentacao WHERE  codigoConta = '{UsuarioLogado.CodigoConta}' and codigoTipoTransacao = 2";
                SqlCommand comando = new SqlCommand(sql, db.conn);

                // Lista para armazenar as movimentações
                List<Movimentacao> movimentacoes = new List<Movimentacao>();

                // Executa a consulta e lê os resultados
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Cria um objeto Movimentacao com os dados do resultado da consulta
                        Movimentacao movimentacao = new Movimentacao
                        {
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                            Datatransacao = reader.GetDateTime(reader.GetOrdinal("dataTransacao"))
                        };


                        movimentacoes.Add(movimentacao);
                    }
                }

                foreach (var movimentacao in movimentacoes)
                {
                    dataGridView1.Rows.Add(
                        movimentacao.Valor.ToString("C"),
                        movimentacao.Datatransacao.ToString("dd/MM/yyyy HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar movimentações: {ex.Message}");
            }



            //GRID DE SAQUE
            dataGridView2.Rows.Clear();
            dataGridView2.ClearSelection();
            try
            {

                string sql = $"SELECT valor,dataTransacao FROM Movimentacao WHERE  codigoConta = '{UsuarioLogado.CodigoConta}' and codigoTipoTransacao = 1";
                SqlCommand comando = new SqlCommand(sql, db.conn);


                List<Movimentacao> movimentacoes = new List<Movimentacao>();


                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Movimentacao movimentacao = new Movimentacao
                        {
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                            Datatransacao = reader.GetDateTime(reader.GetOrdinal("dataTransacao"))

                        };


                        movimentacoes.Add(movimentacao);
                    }
                }

                foreach (var movimentacao in movimentacoes)
                {
                    dataGridView2.Rows.Add(
                        movimentacao.Valor.ToString("C"),
                        movimentacao.Datatransacao.ToString("dd/MM/yyyy HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar movimentações: {ex.Message}");
            }
            finally
            {
                db.Desconectar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


