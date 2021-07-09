using DemoLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IBussinessLogic
    {
        void ProcessData();
    }

    public class BussinessLogic : IBussinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BussinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }


        public void ProcessData()
        {
            _logger.Log("Starting the process of data.");
            Console.WriteLine("Processing data.");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed info");
            _logger.Log("Finishing the process of data.");

        }
    }
}
