using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Services
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string data);
    }

    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loadding data.");
        }

        public void SaveData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
