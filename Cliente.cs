
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace cyberbank
{
    public class Cliente
    {
        //CLASSE
        //CASO QUEIRAM IMPLMENTAR TELEFONE E EMAIL
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Senha { get; set; }
        public int CodigoGenero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }


        //CONSTRUTOR PARA CADASTRO 

        //CASO QUEIRAM IMPLMENTAR TELEFONE E EMAIL
        public Cliente(string nome, DateTime dataNascimento, string cpf, string rg, string senha, int codigoGenero, string estado, string cidade, string bairro, string rua, string numero)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            CodigoGenero = codigoGenero;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }
        //CONSTRUTOR PARA LOGIN
        public Cliente(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;
        }

        public Cliente()
        {

        }



        public bool InserirCadastro(Conexao db, Cliente cliente, Conta conta)
        {
            try
            {
                //CASO QUEIRAM IMPLMENTAR TELEFONE E EMAIL
                // Inserção do Cliente
                string sqlCliente = $"INSERT INTO Cliente (nome, dataNascimento, cpf, rg, senha, codigoGenero, estado, cidade, bairro, rua, numero) " +
                    $"VALUES ('{cliente.Nome}', '{cliente.DataNascimento}', '{cliente.Cpf}', '{cliente.Rg}', '{cliente.Senha}', " +
                    $"{cliente.CodigoGenero},  '{cliente.Estado}', '{cliente.Cidade}', '{cliente.Bairro}', '{cliente.Rua}', '{cliente.Numero}'); " +
                    "SELECT SCOPE_IDENTITY();";
                SqlCommand comandoCliente = new SqlCommand(sqlCliente, db.conn);

                // Executa a inserção do cliente e obtém o ID do cliente inserido
                int codigoClienteInserido = Convert.ToInt32(comandoCliente.ExecuteScalar());

                // Inserção da Conta
                string sqlConta = $"INSERT INTO Conta (saldo, codigoCliente) VALUES (0.00, {codigoClienteInserido})";
                SqlCommand comandoConta = new SqlCommand(sqlConta, db.conn);




                int contagemlinhas = comandoConta.ExecuteNonQuery();

                // NÃO FUNCIONA DIREITO OU NÂO ENTENDI

                if (codigoClienteInserido > 0 && contagemlinhas > 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Falha ao inserir conta.");
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static int InserirGenero(string genero)
        {
            switch (genero)
            {
                case "Feminino":
                    return 1;
                case "Masculino":
                    return 2;
                case "Outros":
                    return 3;
                default:
                    return 0;
            }
        }

        //Verificação Usuário e SEnha
        public bool EfetuarLogin(string cpf, string senha, Conexao db)
        {
            try
            {
                string sql = $"SELECT * FROM Cliente where cpf = '{cpf}' AND senha = '{senha}'";
                SqlCommand comando = new SqlCommand(sql, db.conn);


                var retorno = comando.ExecuteReader();

                if (retorno.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }



        public bool VerificarCampos(string cpf, string senha, string senhaConfirma, MaskedTextBox txtCPF, TextBox txtSenha, TextBox txtSenhaConfirma)
        {
            // Verifica se os campos obrigatórios foram preenchidos corretamente
            bool camposValidos = true;

            if (string.IsNullOrEmpty(cpf))
            {
                txtCPF.ForeColor = Color.Red; // Muda a cor do campo CPF para vermelho
                camposValidos = false;
            }
            else
            {
                txtCPF.ForeColor = SystemColors.ControlText; // Retorna a cor padrão do campo CPF
            }

            if (string.IsNullOrEmpty(senha))
            {
                txtSenha.ForeColor = Color.Red; // Muda a cor do campo senha para vermelho
                camposValidos = false;
            }
            else
            {
                txtSenha.ForeColor = SystemColors.ControlText; // Retorna a cor padrão do campo senha
            }

            if (senha != senhaConfirma)
            {
                txtSenha.ForeColor = Color.Red; // Muda a cor do campo senha para vermelho
                txtSenhaConfirma.ForeColor = Color.Red; // Muda a cor do campo confirmação de senha para vermelho
                camposValidos = false;
            }
            else
            {
                txtSenha.ForeColor = SystemColors.ControlText; // Retorna a cor padrão do campo senha
                txtSenhaConfirma.ForeColor = SystemColors.ControlText; // Retorna a cor padrão do campo confirmação de senha
            }

            return camposValidos;
        }




        public static bool ValidarCPF(string cpf)
        {
            return cpf.Length == 14;
        }

        public List<string> leituraCPF(SqlConnection conn, List<string> cpfRegistrado)
        {
            try
            {
                string sql = "SELECT cpf FROM Cliente";

                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string leitorCPF = reader["cpf"].ToString();
                            cpfRegistrado.Add((leitorCPF));
                        }
                    }
                }

                return cpfRegistrado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler CPFs do banco de dados: {ex.Message}");
                return cpfRegistrado;
            }
        }

    }

}
