using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyberbank
{
    public partial class TelaNavegacao : Form
    {

        public TelaNavegacao()
        {
            InitializeComponent();
            string nomeUsuario = UsuarioLogado.Nome;
            decimal saldoUsuario = UsuarioLogado.Saldo;
            int codigoConta = UsuarioLogado.CodigoConta;
            label1.Text = nomeUsuario;
            label2.Text = saldoUsuario.ToString("C");

        }




        private void btnDepositar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaDeposito telaDeposito = new TelaDeposito();
            telaDeposito.Show();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaSaque telaSaque = new TelaSaque();
            telaSaque.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExtrato telaExtrato = new TelaExtrato();
            telaExtrato.Show();
        }

        private void TelaNavegacao_Load(object sender, EventArgs e)
        {

        }

        private void setaextrato_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExtrato telaExtrato = new TelaExtrato();
            telaExtrato.Show();
        }

        private void setasaque_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaSaque telaSaque = new TelaSaque();
            telaSaque.Show();
        }

        private void setadeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaDeposito telaDeposito = new TelaDeposito();
            telaDeposito.Show();
        }

        private void setasair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
    }
}
