using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    // Это бухгалтер. Он тоже работник.
    class Accountant : Worker
    {
        // Он знает обо всех главах отделов.
        public IEnumerable<DepartmentHead> DepartmentHeads { get; set; }

        // Он может начать ДЕНЬ ЗАР. ПЛАТЫ!
        public void PayDay()
        {
            // Проходим циклов по всем главам отделов.
            foreach (var head in DepartmentHeads)
            {
                // А потом по платёжкам, которые они нам дали.
                foreach (var order in head.GetPaymentOrders())
                {
                    // И платим работникам согласно платёжкам.
                    order.Worker.GivePayment(order.Value);
                }
            }

            // Ну и, как величайший жучара, бухгалтер платит сам себе 100500 денег.
            GivePayment(100500);
        }
    }
}
