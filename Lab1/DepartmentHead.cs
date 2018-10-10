using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    // Это глава отела. Он тоже работник.
    class DepartmentHead : Worker
    {
        // Тут указано З/П по отделу. Для всех, да.
        // Ну а что? Начальник ведь решает.
        public uint DepartmentSalary { get; set; }

        // Это щедрость начальника. Он может повысить З/П сотрудников,
        // а может снизить. Щедрость/100 - вот по такому коэффициенту.
        public uint Bounty { get; set; }

        // Здесь перечислены работники в его подчинении.
        public IEnumerable<Worker> Workers { get; set; }

        // Вот так бухгалтер запрашивает у него набор платёжек для его подчинённых.
        public IEnumerable<PaymentOrder> GetPaymentOrders()
        {
            // Создаём список.
            var result = new List<PaymentOrder>();
            // Проходим циклом по всем сотрудникам.
            foreach (var worker in Workers)
            {
                // И добавляем платёжку для них в список.
                result.Add(new PaymentOrder
                {
                    Worker = worker,
                    // ЗП * Щедрость / 100
                    Value = DepartmentSalary * Bounty / 100
                });
            }

            // Как самый хитрый, начальник ставит себе З/П в 1.5 раза больше, чем у работников.
            // Такой вот жук, да.
            result.Add(new PaymentOrder
            {
                Worker = this,
                // 3 * ЗП * Щедрость / 200 = 1.5 * ЗП * Щедрость / 100
                Value = DepartmentSalary * Bounty * 3 / 200
            });
            // Возвращаем список.
            return result;
        }
    }
}
