using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDLL.Entities
{
    public class CardDriverDLL
    {
        private string pathImage;
        private string name;
        private string team;

        public CardDriverDLL(string pathImage, string name, string team)
        {
            this.PathImage = pathImage;
            this.Name = name;
            this.Team = team;
        }

        public string PathImage { get => pathImage; set => pathImage = value; }
        public string Name { get => name; set => name = value; }
        public string Team { get => team; set => team = value; }
    }

    public class TableDriverDLL
    {
        private string forename;
        private string surname;
        private int number;
        private string dob;
        private string nationality;
        private string url;

        public TableDriverDLL(string forename, string surname, int number, string dob, string nationality, string url)
        {
            this.forename = forename;
            this.surname = surname;
            this.number = number;
            this.dob = dob;
            this.nationality = nationality;
            this.url = url;
        }

        public string Forename { get => forename; set => forename = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Number { get => number; set => number = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Url { get => url; set => url = value; }
    }

    public class DriverDLL
    {
        public List<CardDriverDLL> LoadDrivers(string year)
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";
            List<CardDriverDLL> retVal = new List<CardDriverDLL>();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneStudioDB.mdf;Integrated Security=True");
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT DISTINCT drivers.PathImgSmall, drivers.forename, drivers.surname, constructors.name " +
                  "FROM drivers, races, results, constructors " +
                  "WHERE drivers.driverId = results.driverId " +
                  "AND races.raceId = results.raceId " +
                  "AND results.constructorId = constructors.constructorId " +
                  $"AND races.year = {year} " +
                  "ORDER BY drivers.surname ASC",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        CardDriverDLL card = new CardDriverDLL(
                        reader.GetString(0),
                        $"{reader.GetString(1)} {reader.GetString(2)}",
                        reader.GetString(3)
                        );
                        retVal.Add(card);
                    }
                    catch (Exception)
                    {
                        //CardDriverDLL card = new CardDriverDLL(
                        //reader.GetString(0),
                        //reader.GetString(1),
                        //"null"
                        //);
                        //retVal.Add(card);
                    }


                }
                reader.Close();
            }
            return retVal;
        }

        public List<TableDriverDLL> LoadTableDrivers(string year)
        {
            string WORKINGPATH = $@"C:\Users\{Environment.UserName}\Documents\MSSQLDatabase\FormulaOne\";
            List<TableDriverDLL> retVal = new List<TableDriverDLL>();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOneStudioDB.mdf;Integrated Security=True");
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT DISTINCT drivers.forename, drivers.surname, drivers.number, drivers.dob, drivers.nationality, drivers.url " +
                  "FROM drivers, races, results " +
                  "WHERE drivers.driverId = results.driverId " +
                  "AND races.raceId = results.raceId " +
                  $"AND races.year = {year} " +
                  "ORDER BY drivers.surname ASC",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        TableDriverDLL card = new TableDriverDLL(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3).Date.ToShortDateString(),
                            reader.GetString(4),
                            reader.GetString(5)
                        );
                        retVal.Add(card);
                    }
                    catch (Exception)
                    {
                        TableDriverDLL card = new TableDriverDLL(
                            reader.GetString(0),
                            reader.GetString(1),
                            0,
                            reader.GetDateTime(3).Date.ToShortDateString(),
                            reader.GetString(4),
                            reader.GetString(5)
                        );
                        retVal.Add(card);
                    }


                }
                reader.Close();
            }
            return retVal;
        }

    }
}
