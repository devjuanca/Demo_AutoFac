using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AutoFac
{
    public interface IApplication
    {
        void Run();
    }

    public class Application : IApplication
    {
        IBussinessLogic _bussinessLogic;
        public Application(IBussinessLogic bussinessLogic)
        {
            _bussinessLogic = bussinessLogic;
        }

        public void Run()
        {
            _bussinessLogic.ProcessData();
        }

    }
}
