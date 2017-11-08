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
        ImportCSV import = new ImportCSV();
        SqlConnection myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");
        public void AddPetToDatabase()
        {

        }
        public void RemovePetFromDatabase()
        {

        }
        public void ImportCSV()
        {
            FileStream thisFile = new FileStream("../../inmateTransferList.csv",FileMode.Open);
            StreamReader sr = new StreamReader(thisFile);
            
        }
    }
}
