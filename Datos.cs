using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public class Datos
    {
        private string connectionString = @"server=localhost;userid=root;password=123456;database=prueba";

        public Datos()
        {

        }

        public DataTable GetContactos()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM contactos";

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    using (var dataAdapter = new MySqlDataAdapter())
                    {
                        var dataTable = new DataTable();

                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public DataRow GetContacto(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM contactos WHERE Id = @Id";

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@Id", id);

                    using (var dataAdapter = new MySqlDataAdapter())
                    {
                        dataAdapter.SelectCommand = command;

                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            return dataTable.Rows[0];
                        }

                        return null;
                    }
                }
            }
        }

        public void Insertar(string nombre, string email, string sexo, bool mayorDeEdad)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO contactos (Nombre, Email, Sexo, MayorDeEdad)
                    VALUES(@nombre, @email, @sexo, @mayorDeEdad)";

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@mayorDeEdad", mayorDeEdad);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(string nombre, string email, string sexo, bool mayorDeEdad, int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    UPDATE contactos SET Nombre = @nombre, Email = @email, Sexo = @sexo,
                    MayorDeEdad = @mayorDeEdad WHERE ID = @Id;";

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@mayorDeEdad", mayorDeEdad);
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM contactos WHERE ID = @Id";

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
