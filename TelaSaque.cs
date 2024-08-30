using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cyberbank
{
    public partial class TelaSaque : Form
    {
        public TelaSaque()
        {
            InitializeComponent();
        }

        private void btnConfirmarSaque_Click(object sender, EventArgs e)
        {
            decimal valorSaque = txtSaque.Value; // Certifique-se de que txtSaque é um controle apropriado, como NumericUpDown

            Movimentacao movimentacao = new Movimentacao();

            decimal saldoAtual = UsuarioLogado.Saldo;

            if (valorSaque > 0 && valorSaque <= saldoAtual)
            {
                DialogResult result = MessageBox.Show($"Você está fazendo uma transação de {valorSaque.ToString("C")}.\n" +
                    "Deseja confirmar essa operação?", "Operação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("Operação concluída");

                    Conexao db = new Conexao();
                    try
                    {
                        db.Conectar();

                        bool sucesso = movimentacao.RealizarSaque(valorSaque, db);

                        if (sucesso)
                        {
                            MessageBox.Show("Saque realizado com sucesso!");
                            this.Hide();
                            TelaNavegacao telaNavegacao = new TelaNavegacao();
                            telaNavegacao.Show();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao realizar saque.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}");
                    }
                    finally
                    {
                        db.Desconectar();
                    }
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido ou Saldo insuficiente");
            }
        }

        private void btnCancelarSaque_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaNavegacao telaNavegacao = new TelaNavegacao();
            telaNavegacao.Show();
        }

        private void TelaSaque_Load(object sender, EventArgs e)
        {
            // Evento de carregamento (se necessário)
        }

        private void btnSaqueCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

