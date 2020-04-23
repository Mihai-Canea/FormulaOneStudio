using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL.Entities
{

    public class CircuitsTableDLL
    {
        private string name;
        private string location;
        private string country;
        private string url;

        public CircuitsTableDLL(string name, string location, string country, string url)
        {
            this.name = name;
            this.location = location;
            this.country = country;
            this.url = url;
        }

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Country { get => country; set => country = value; }
        public string Url { get => url; set => url = value; }
    }
    public class CircuitsDLL
    {
        public List<CircuitsTableDLL> LoadTableCircuits(string year)
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";
            List<CircuitsTableDLL> retVal = new List<CircuitsTableDLL>();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneStudioDB.mdf;Integrated Security=True");
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT circuits.name, circuits.location , circuits.country, circuits.url FROM circuits ",
                  //"ORDER BY drivers.surname ASC",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CircuitsTableDLL circuit = new CircuitsTableDLL(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    );
                    retVal.Add(circuit);
                }
                reader.Close();
            }
            return retVal;
        }
    }
}
