using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отдел продаж
            var saler1 = new Worker {Name = "Маша"};
            var saler2 = new Worker {Name = "Лена"};
            var saler3 = new Worker {Name = "Игорь"};
            var mainSaler = new DepartmentHead
            {
                Name = "Лиза",
                // Лиза щедрая, она увеличивает З/П сотрудников.
                Bounty = 150,
                DepartmentSalary = 40_000,
                Workers = new Worker[] {saler1, saler2, saler3}
            };

            // Отдел звонков
            var caller1 = new Worker {Name = "Валера"};
            var caller2 = new Worker {Name = "Вероника"};
            var caller3 = new Worker {Name = "Иван"};
            var mainCaller = new DepartmentHead
            {
                Name = "Пётр",
                // А Пётр - скупердяй, он уменьшает З/П сотрудников.
                Bounty = 90,
                DepartmentSalary = 45_000,
                Workers = new Worker[] { caller1, caller2, caller3}
            };

            var acc = new Accountant
            {
                Name = "Валентина Петровна",
                DepartmentHeads = new DepartmentHead[] {mainSaler, mainCaller}
            };

            // Запускаем ДЕНЬ ЗАР. ПЛАТЫ!
            acc.PayDay();

            Console.ReadKey();
        }
    }
}