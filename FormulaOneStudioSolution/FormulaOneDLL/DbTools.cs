using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL
{
    public class DbTools
    {

        public void ExecuteSqlScript(string sqlScriptName)
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";

            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneDB.mdf;Integrated Security=True");
            var cmd = new SqlCommand("query", con);
            con.Open(); int i = 0;
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query; i++;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    Console.WriteLine("Errore in esecuzione della query numero: " + i);
                    Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message);
                }
            }
            con.Close();
        }

        public List<CardDriverDLL> LoadDrivers()
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";
            List<CardDriverDLL> retVal = new List<CardDriverDLL>();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneDB.mdf;Integrated Security=True");
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT PathImgSmall,Name,Team FROM Drivers ORDER BY Team ASC;",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CardDriverDLL card = new CardDriverDLL(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2)
                        );
                    retVal.Add(card);
                }
                reader.Close();
            }
            return retVal;
        }

        public DataTable LoadTableDrivers()
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";
            DataTable dt = new DataTable();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneDB.mdf;Integrated Security=True");
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Drivers ORDER BY Team ASC;",
                  con);
                con.Open();

                //SqlDataReader reader = command.ExecuteReader();
                dt = EseguiQuery(command);
                return dt;
            }
        }

        /// <summary>
        /// Esegue una query che ritorna un dataTable
        /// </summary>
        /// <param name="cmd">Comando Query</param>
        /// <returns>dataTable</returns>
        public DataTable EseguiQuery(SqlCommand cmd)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter(cmd);
            try
            {
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

    }
}
