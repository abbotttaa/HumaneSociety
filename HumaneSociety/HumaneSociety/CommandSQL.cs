using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CommandSQL
    {
        string choice;
        string choiceRow;
        public string CraftSQLRemove()
        {
            string SQLRemove = ("DELETE FROM " + choiceRow + " WHERE  " + CustomerName + " = '"+ choice +"'; ")
        }
        public string CraftSQLAdd()
        {

        }
        public string CraftSQLCheck()
        {
            
        }
    }
}
