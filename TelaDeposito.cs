using cyberbank;
using System;
using System.Windows.Forms;


namespace cyberbank
{
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            decimal valorDeposito = digitarSaldo.Value;

            if (valorDeposito > 0)
            {
                DialogResult result = MessageBox.Show($"Você está fazendo uma transação de {valorDeposito.ToString("C")}.\n" +
                    "Deseja confirmar essa operação?", "Operação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Conexao db = new Conexao();
                    try
                    {
                        db.Conectar();

                        Movimentacao movimentacao = new Movimentacao();
                        bool sucesso = movimentacao.RealizarDeposito(valorDeposito, db);

                        if (sucesso)
                        {
                            MessageBox.Show("Depósito realizado com sucesso!");
                            this.Hide();
                            TelaNavegacao telaNavegacao = new TelaNavegacao();
                            telaNavegacao.Show();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao realizar depósito.");
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
                    MessageBox.Show("Operação cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, Digite um valor válido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaNavegacao telaNavegacao = new TelaNavegacao();
            telaNavegacao.Show();
        }

        private void digitarSaldo_ValueChanged(object sender, EventArgs e)
        {
            // Evento de mudança de valor (se necessário)
        }

        private void TelaDeposito_Load(object sender, EventArgs e)
        {
            // Evento de carregamento (se necessário)
        }
    }
}

