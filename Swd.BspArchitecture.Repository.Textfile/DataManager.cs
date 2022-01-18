using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.BspArchitecture.Repository.Textfile
{
    public class DataManager
    {

        public string ReadData()
        {
            string returnValue = String.Empty;
            string filePath = Properties.Settings.Default.PathToTextfile;

            //string fileName = "Repository.txt";
            //string pathToFile = @"D:\Projekte\SWDeveloper2021\Swd.Daten";
            //string completPath = Path.Combine(pathToFile,fileName);
            //string temporaryPath = Path.GetTempPath();
            //string randomFile = Path.GetRandomFileName();
            //string extension = Path.GetExtension(completPath);
            //string fileName2 = Path.GetFileName(completPath);
            //string pathToFile2 = Path.GetDirectoryName(completPath);
            //Directory.CreateDirectory(pathToFile);
            //DirectoryInfo dir = new DirectoryInfo(pathToFile);
            //File.Create(pathToFile);
            //FileInfo file = new FileInfo(pathToFile);
            if (File.Exists(filePath))
            {
                returnValue = System.IO.File.ReadAllText(filePath);
            }
            return returnValue;
        }


    }
}
