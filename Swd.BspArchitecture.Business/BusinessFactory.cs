using Swd.BspArchitecture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.BspArchitecture.Business
{
    public class BusinessFactory
    {


        public string GetBusinessData()
        {

            string displayText = string.Empty;

            DataFactory factory = new DataFactory();
            displayText = factory.GetData();

            return string.Format("{0} {1}", displayText, DateTime.Now);
        }



    }
}
