using Swd.BspArchitecture.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.BspArchitecture.Repository.Database
{
    public class DataManager
    {
        public string ReadData()
        {
            string returnValue = string.Empty;

            Bsp_ArchitectureEntities db = new Bsp_ArchitectureEntities();


            foreach (Message item in db.Messages)
            {
                var t = item.AnzeigeText;
            }

            Message newMsg = new Message();
            newMsg.AnzeigeText = "Test";
            newMsg.Sichtbar = true;

            db.Messages.Add(newMsg);
            db.SaveChanges();

            Message newMessage = db.Messages.FirstOrDefault();
            returnValue = newMessage.AnzeigeText;

            return returnValue;
        }

    }
}
