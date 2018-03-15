using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Subject
    {
        public IList<Observer> observers = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void UnSubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify(StatusObserverVM statusVM)
        {
            foreach (Observer observer in observers)
            {
                observer.Update(statusVM);
            }
        }
    }
}
