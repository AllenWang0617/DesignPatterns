using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ConcreteSubject : Subject
    {
        public ConcreteSubject()
        {
            Subscribe(new ConcreteObserver());
            Subscribe(new ConcreteObserver2());
        }

        public void Update()
        {
            var statusVM = new StatusObserverVM()
            {
                Status = 1
            };

            Notify(statusVM);
        }
    }
}
