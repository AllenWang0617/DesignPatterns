using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        public static Singleton instance;
        public static readonly Object locker = new Object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock (locker)
            {
                return instance ?? (instance = new Singleton());
            }
        }
    }
}
