using System;
using System.Data.SqlClient;

namespace AppADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().CreateTable();
            //new Program().InsertRecord();
            //new Program().RetrieveRecord();
            new Program().DeleteRecord();
        }

        #region CreateTable
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

        #region  Insert Records
        public void InsertRecord()
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

                SqlCommand cm = new SqlCommand("INSERT INTO Student (id, name, email, join_date)" +
                    " VALUES ('101', 'Mateus Augusto', 'email@email.com',  '1/12/2021')", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Registro inserido com sucesso!");
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

        #region Retrieve Records
        public void RetrieveRecord()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; " +
                    "Initial Catalog=School;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False");

                SqlCommand cm = new SqlCommand("SELECT * FROM Student", con);

                con.Open();

                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["join_date"]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }

            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Deleting Records
        public void DeleteRecord()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; " +
                    "Initial Catalog=School;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False");

                // writing sql query  
                SqlCommand cm = new SqlCommand("DELETE FROM Student WHERE id = '101'", con);

                // Opening Connection  
                con.Open();

                // Executing the SQL query  
                cm.ExecuteNonQuery();

                Console.WriteLine("Record Deleted Successfully");
            }

            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
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

