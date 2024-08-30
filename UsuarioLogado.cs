using cyberbank;
using System.Data.SqlClient;
using System.Data;

public class UsuarioLogado
{
    public static string Nome { get; private set; }
    public static decimal Saldo { get; private set; }
    public static int CodigoConta { get; set; }
   

    public UsuarioLogado(string nomeConta, decimal saldoConta, int codigoConta)
    {
        Nome = nomeConta;
        Saldo = saldoConta;
        CodigoConta = codigoConta;
    }

    public static void DefinirUsuarioLogado(string nome, decimal saldo, int codigoConta)
    {
        Nome = nome;
        Saldo = saldo;
        CodigoConta = codigoConta;
    }


    public static void AtualizarSaldo(decimal novoSaldo)
    {
        Saldo = novoSaldo;
    }

    public static string ObterNomeCliente(string cpf, Conexao db)
    {
        string nomeCliente = "Cliente não encontrado";

        string sql = $"SELECT Nome FROM Cliente WHERE cpf = '{cpf}'";

        using (SqlCommand comando = new SqlCommand(sql, db.conn))
        {
            try
            {
                db.conn.Open(); // Abre a conexão
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nomeCliente = reader.GetString(reader.GetOrdinal("Nome"));
                    }
                } // O using garante que o reader seja fechado aqui
            }
            finally
            {
                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close(); // Fecha a conexão, se estiver aberta
                }
            }
        }

        return nomeCliente;
    }

    public static decimal ObterSaldo(string cpf, SqlConnection connection)
    {
        decimal saldoCliente = 0;

        string sql = $"SELECT Saldo FROM Conta WHERE codigoCliente = (SELECT codigo FROM Cliente WHERE cpf = '{cpf}')";

        using (SqlCommand comando = new SqlCommand(sql, connection))
        {
            try
            {
                connection.Open(); // Abre a conexão
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        saldoCliente = reader.GetDecimal(reader.GetOrdinal("Saldo"));
                    }
                } // O using garante que o reader seja fechado aqui
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Fecha a conexão, se estiver aberta
                }
            }
        }

        return saldoCliente;
    }


    public static int ObterCodigoConta(string cpf, Conexao db)
    {
        int codigoConta = -1; // Valor padrão para indicar conta não encontrada

        string sql = $"SELECT codigo FROM Conta WHERE codigoCliente = (SELECT codigo FROM Cliente WHERE cpf = '{cpf}')";

        using (SqlCommand comando = new SqlCommand(sql, db.conn))
        {
            try
            {
                db.conn.Open(); // Abre a conexão
                var resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    codigoConta = Convert.ToInt32(resultado);
                }
            }
            finally
            {
                if (db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close(); // Fecha a conexão, se estiver aberta
                }
            }
        }

        return codigoConta;
    }
}

