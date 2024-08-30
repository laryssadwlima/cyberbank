using System;
using System.Drawing;
using System.Windows.Forms;

namespace cyberbank
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            // Configura o campo de senha para exibir bullets
            textBoxsenha.PasswordChar = '�';
        }

        private void buttoncriarconta_Click(object sender, EventArgs e)
        {
            //Ap�s criar a conta voltar para tela de login
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string cpf = textBoxcpf.Text;
            string senha = textBoxsenha.Text;

            Conexao db = new Conexao();
            db.Conectar();

            Cliente cliente = new Cliente(cpf, senha);
            var retorno = cliente.EfetuarLogin(cpf, senha, db);

            db.Desconectar();

            if (retorno)
            {
                // Obt�m as informa��es do cliente logado
                string nomeCliente = UsuarioLogado.ObterNomeCliente(cpf, db);
                decimal saldoCliente = UsuarioLogado.ObterSaldo(cpf, db.conn);
                int codigoConta = UsuarioLogado.ObterCodigoConta(cpf, db);

                // Configura o usu�rio logado com as informa��es obtidas
                UsuarioLogado.DefinirUsuarioLogado(nomeCliente, saldoCliente, codigoConta);

                MessageBox.Show("Login Conclu�do");

                // Abre a tela de navega��o
                TelaNavegacao telaNavegacao = new TelaNavegacao();
                telaNavegacao.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados Incorretos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //design da tela
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
