using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety
{
    class DatabaseManagment
    {
        public string pet;
        ImportCSV import = new ImportCSV();
        SqlConnection myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");
        public DatabaseManagment(string pet)
        {
            this.pet= pet;
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            SqlCommand myCommand = new SqlCommand();
        }
        public void ConnectToDatabase()
        {
            pet = "0";
            SqlCommand myCommand = new SqlCommand(pet, myConnection);
            myCommand.ExecuteNonQuery();
        }
        public void CheckDatabaseForMatches()
        {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Animals", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine(myReader["Column1"].ToString());
                    Console.WriteLine(myReader["Column2"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void AddPetToDatabase()
        {

        }
        public void RemovePetFromDatabase()
        {

        }
        public void ImportCSV()
        {
            import.ImportNewCsv();
        }      
    }
}
