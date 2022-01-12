using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
using Swd.BspArchitecture.Repository.Textfile;

namespace Swd.BspArchitecture.Repository
{
    public class DataFactory
    {

        public string GetData()
        {

            string returnValue = string.Empty;

            DataManager manager = new DataManager();
            returnValue = manager.ReadData();

            return returnValue;
        }



    }




}
