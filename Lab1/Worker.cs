using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    // Работик
    class Worker
    {
        // У него есть имя
        public string Name { get; set; }

        // И он может получать З/П
        public void GivePayment(uint value)
        {
            Console.WriteLine("{0} получил(а) заработную плату в размере {1}", Name, value);
        }
    }
}
