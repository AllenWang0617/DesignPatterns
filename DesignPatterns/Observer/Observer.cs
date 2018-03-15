using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public abstract class Observer
    {
        public abstract void Update(StatusObserverVM statusVM);
    }
}
