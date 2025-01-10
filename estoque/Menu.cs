using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Mozilla;

namespace estoque
{
    public class Menu
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string medida { get; set; }
        public string cor { get; set; }
        public string quantidade { get; set; }
        public string foto { get; set; }

        public void Adicionar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO estoque (modelo, medida, cor, quantidade, foto) VALUES (@modelo, @medida, @cor, @quantidade, @foto)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@medida", medida);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("UPDATE estoque SET modelo = @modelo, medida = @medida, cor = @cor, quantidade = @quantidade, foto = @foto WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo);
                Banco.Comando.Parameters.AddWithValue("@medida", medida);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@quantidade", quantidade);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM estoque WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT * FROM estoque WHERE modelo LIKE @modelo " +
                    "ORDER BY modelo", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@modelo", modelo + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();

                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

    }
}
