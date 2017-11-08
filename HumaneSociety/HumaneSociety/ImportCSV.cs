using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace HumaneSociety
{
    class ImportCSV
    {
       public void ImportNewCsv()
        {
            FileStream thisFile = new FileStream("../../inmateTransferList.csv", FileMode.Open);
            StreamReader sr = new StreamReader(thisFile);
        }
    }
}
