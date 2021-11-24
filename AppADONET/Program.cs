using System;
using System.Data.SqlClient;

namespace AppADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        #region
        public void CreateTable()
        {
            SqlConnection con = null;

            try
            {
                // Criar Conexão
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=School;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False");

                SqlCommand cm = new SqlCommand("CREATE TABLE Student(id int not null," +
                    "name varchar(100), email varchar(50), join_date date)", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Tabela criada com sucesso");

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }

            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        #endregion


    }
}
