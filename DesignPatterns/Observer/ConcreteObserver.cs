using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ConcreteObserver : Observer
    {
        public override void Update(StatusObserverVM statusVM)
        {
            Console.WriteLine("Subscriber's status change to :" + statusVM.Status);
        }
    }
}
