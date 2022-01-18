using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;


namespace Swd.BspArchitecture.Repository
{
    public class DataFactory
    {

        public string GetData()
        {
            DataSource datasource = (DataSource)Properties.Settings.Default.DataSource;
            
            string returnValue = string.Empty;

            switch (datasource)
            {
                case DataSource.Memory:
                    break;
                case DataSource.Textfile:
                    Textfile.DataManager dataManagerTextFile = new Textfile.DataManager();
                    returnValue = dataManagerTextFile.ReadData();
                    break;
                case DataSource.XmlFile:
                    XmlFile.DataManager dataManagerXmlFile = new XmlFile.DataManager();
                    returnValue = dataManagerXmlFile.ReadData();
                    break;
                case DataSource.Database:
                    Database.DataManager dataManagerDatabase = new Database.DataManager();
                    returnValue = dataManagerDatabase.ReadData();
                    break;
                default:
                    break;
            }

            return returnValue;
        }



    }




}
