using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cyberbank
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void buttoncriarconta_Click(object sender, EventArgs e)
        {
            // variaceis para atribuir as caixas de texto 
            string nome = textBoxnomecliente.Text;
            DateTime dataNascimento = textdatanascimento.Value;
            string cpf = textBoxcpf.Text;
            string rg = textBoxrg.Text;
            string senha = textBoxsenha.Text;
            string senhaConfirma = textBoxconfirmarconta.Text;
            int codigoGenero = Cliente.InserirGenero(comboBoxgenero.Text);
            string estado = textBoxestado.Text;
            string cidade = textBoxcidade.Text;
            string bairro = textBoxbairro.Text;
            string rua = textBoxrua.Text;
            string numero = textBoxnumero.Text;

            // Resetar as cores do campos de texto
            ResetarCoresDosCampos();

            // Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(rg) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(senhaConfirma) ||
                string.IsNullOrWhiteSpace(estado) || string.IsNullOrWhiteSpace(cidade) ||
                string.IsNullOrWhiteSpace(bairro) || string.IsNullOrWhiteSpace(rua) || string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                MarcarCamposObrigatorios(nome, cpf, rg, senha, senhaConfirma, estado, cidade, bairro, rua, numero);
                return;
            }

            // Verificação da data de nascimento (se e maior que 18 anos)
            if (!ValidarDataNascimento(dataNascimento))
            {
                MessageBox.Show("O cliente deve ter pelo menos 18 anos.");
                textdatanascimento.CalendarForeColor = Color.Red;
                return;
            }

            // Verificação do RG (9 digitos)
            if (!ValidarRG(rg))
            {
                MessageBox.Show("O RG deve conter exatamente 9 dígitos.");
                textBoxrg.ForeColor = Color.Red;
                return;
            }

            // Verificação da senha se  é de 4 a 6 digitos
            if (!ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve conter entre 4 e 6 dígitos numéricos.");
                textBoxsenha.ForeColor = Color.Red;
                return;
            }

            // Verificação da confirmação da senha
            if (senha != senhaConfirma)
            {
                MessageBox.Show("As senhas não coincidem.");
                textBoxsenha.ForeColor = Color.Red;
                textBoxconfirmarconta.ForeColor = Color.Red;
                return;
            }

            //
            Conta conta = new Conta();
            Cliente cliente = new Cliente(nome, dataNascimento, cpf, rg, senha, codigoGenero, estado, cidade, bairro, rua, numero);

            List<string> cpfRegistrado = new List<string>();

            Conexao db = new Conexao();
            db.Conectar();

            bool dadosPreenchidosCorretamente = false;

            while (!dadosPreenchidosCorretamente)
            {
                // Verifica se os campos obrigatórios foram preenchidos corretamente
                bool camposValidos = cliente.VerificarCampos(cpf, senha, senhaConfirma, textBoxcpf, textBoxsenha, textBoxconfirmarconta);

                if (!camposValidos)
                {
                    MessageBox.Show("Por favor, informe os dados corretamente.");
                    return;
                }
                cliente.leituraCPF(db.conn, cpfRegistrado);

                // Verifica se o CPF já está registrado
                if (cpfRegistrado.Contains(cpf))
                {
                    MessageBox.Show("CPF já registrado.");
                    textBoxcpf.ForeColor = Color.Red;
                    return;
                }

                dadosPreenchidosCorretamente = true;
            }

            // Código para inserir o cliente
            cliente.InserirCadastro(db, cliente, conta);

            db.Desconectar();

            MessageBox.Show($"Cliente inserido com sucesso: {cpf}, {senha}");

            // Somente após inserção bem-sucedida exibe a tela de login
            this.Hide();

            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            //botao voltar para tela de login
            this.Hide();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //design da tela foto
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarSenha(string senha)
        {
            // Verifica se a senha contém apenas dígitos e se tem entre 4 e 6 caracteres
            return Regex.IsMatch(senha, @"^\d{4,6}$");
        }

        private bool ValidarRG(string rg)
        {
            // Verifica se o RG contém exatamente 9 dígitos
            return Regex.IsMatch(rg, @"^\d{9}$");
        }

        private bool ValidarDataNascimento(DateTime dataNascimento)
        {
            // Calcula a idade do cliente
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade))
            {
                idade--;
            }

            // Verifica se a idade é maior ou igual a 18 anos
            return idade >= 18;
        }

        private void ResetarCoresDosCampos()
        {
            textBoxnomecliente.ForeColor = Color.Black;
            textBoxcpf.ForeColor = Color.Black;
            textBoxrg.ForeColor = Color.Black;
            textBoxsenha.ForeColor = Color.Black;
            textBoxconfirmarconta.ForeColor = Color.Black;
            textBoxestado.ForeColor = Color.Black;
            textBoxcidade.ForeColor = Color.Black;
            textBoxbairro.ForeColor = Color.Black;
            textBoxrua.ForeColor = Color.Black;
            textBoxnumero.ForeColor = Color.Black;
            textdatanascimento.CalendarForeColor = Color.Black;
        }

        private void MarcarCamposObrigatorios(string nome, string cpf, string rg, string senha, string senhaConfirma, string estado, string cidade, string bairro, string rua, string numero)
        {
            if (string.IsNullOrWhiteSpace(nome))
                textBoxnomecliente.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(cpf))
                textBoxcpf.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(rg))
                textBoxrg.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(senha))
                textBoxsenha.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(senhaConfirma))
                textBoxconfirmarconta.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(estado))
                textBoxestado.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(cidade))
                textBoxcidade.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(bairro))
                textBoxbairro.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(rua))
                textBoxrua.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(numero))
                textBoxnumero.ForeColor = Color.Red;
        }

        private void buttoncancelar_Click_1(object sender, EventArgs e)
        {
            //botao voltar para tela de login
            this.Hide();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void textBoxcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsenha_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelnome_Click(object sender, EventArgs e)
        {

        }
    }
}
