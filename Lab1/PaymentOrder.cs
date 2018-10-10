using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    // Это платёжка. Она для бухгалтера.
    class PaymentOrder
    {
        // Тут указано кому платить.
        public Worker Worker { get; set; }

        // Тут указано сколько платить.
        public uint Value { get; set; }
    }
}
