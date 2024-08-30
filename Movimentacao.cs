using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyberbank
{
    public class Movimentacao
    {
        public int CodigoConta { get; set; }
        public int CodigoTipoTransacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Datatransacao { get; set; }

        public bool RealizarDeposito(decimal valor, Conexao db)
        {
            int codigoConta = UsuarioLogado.CodigoConta;
            decimal novoSaldo = UsuarioLogado.Saldo + valor;
            int codigoDeposito = 2;
            DateTime dataAtual = DateTime.Now;

            try
            {
                string sqlAtualizarSaldo = "UPDATE Conta SET saldo = @novoSaldo WHERE codigo = @codigoConta";
                SqlCommand comandoAtualizarSaldo = new SqlCommand(sqlAtualizarSaldo, db.conn);
                comandoAtualizarSaldo.Parameters.AddWithValue("@novoSaldo", novoSaldo);
                comandoAtualizarSaldo.Parameters.AddWithValue("@codigoConta", codigoConta);

                int linhasAfetadas = comandoAtualizarSaldo.ExecuteNonQuery();

                string sqlMovimentacao = "INSERT INTO Movimentacao (codigoConta, codigoTipoTransacao, dataTransacao, valor) " +
                                         "VALUES (@codigoConta, @codigoDeposito, @dataAtual, @valor)";
                SqlCommand comandoMovimentacao = new SqlCommand(sqlMovimentacao, db.conn);
                comandoMovimentacao.Parameters.AddWithValue("@codigoConta", codigoConta);
                comandoMovimentacao.Parameters.AddWithValue("@codigoDeposito", codigoDeposito);
                comandoMovimentacao.Parameters.AddWithValue("@dataAtual", dataAtual);
                comandoMovimentacao.Parameters.AddWithValue("@valor", valor);

                int linhasAfetadasMovimentacao = comandoMovimentacao.ExecuteNonQuery();

                if (linhasAfetadas > 0 && linhasAfetadasMovimentacao > 0)
                {
                    UsuarioLogado.AtualizarSaldo(novoSaldo);
                    return true;
                }
                else
                {
                    throw new Exception("Falha ao realizar depósito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar depósito: {ex.Message}");
                return false;
            }
        }

        public bool RealizarSaque(decimal valor, Conexao db)
        {
            int codigoConta = UsuarioLogado.CodigoConta;
            decimal novoSaldo = UsuarioLogado.Saldo - valor;
            int codigoSaque = 1;
            DateTime dataAtual = DateTime.Now;

            try
            {
                string sqlAtualizarSaldo = "UPDATE Conta SET saldo = @novoSaldo WHERE codigo = @codigoConta";
                SqlCommand comandoAtualizarSaldo = new SqlCommand(sqlAtualizarSaldo, db.conn);
                comandoAtualizarSaldo.Parameters.AddWithValue("@novoSaldo", novoSaldo);
                comandoAtualizarSaldo.Parameters.AddWithValue("@codigoConta", codigoConta);

                int linhasAfetadas = comandoAtualizarSaldo.ExecuteNonQuery();

                string sqlMovimentacao = "INSERT INTO Movimentacao (codigoConta, codigoTipoTransacao, dataTransacao, valor) " +
                                         "VALUES (@codigoConta, @codigoSaque, @dataAtual, @valor)";
                SqlCommand comandoMovimentacao = new SqlCommand(sqlMovimentacao, db.conn);
                comandoMovimentacao.Parameters.AddWithValue("@codigoConta", codigoConta);
                comandoMovimentacao.Parameters.AddWithValue("@codigoSaque", codigoSaque);
                comandoMovimentacao.Parameters.AddWithValue("@dataAtual", dataAtual);
                comandoMovimentacao.Parameters.AddWithValue("@valor", valor);

                int linhasAfetadasMovimentacao = comandoMovimentacao.ExecuteNonQuery();

                if (linhasAfetadas > 0 && linhasAfetadasMovimentacao > 0)
                {
                    UsuarioLogado.AtualizarSaldo(novoSaldo);
                    return true;
                }
                else
                {
                    throw new Exception("Falha ao realizar saque.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar saque: {ex.Message}");
                return false;
            }
        }
    }
}
