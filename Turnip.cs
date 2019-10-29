using System.Collections.Generic;
using System.Linq;
using Persons;

namespace Turnip
{
    class Turnip
    {
        private List<Person> _Family;

        public Turnip(List<Person> Family)
        {
            _Family = Family;
        }

        public void DoubleSearch()
        {
            System.Console.WriteLine("Проверяем на повторных членов семьи");
            var query = _Family.GroupBy(x => x)
                        .Where(g => g.Count() > 1).Count();
            if (query >= 1)
                System.Console.WriteLine("Найдены повторные члены семьи\n");
            else
                System.Console.WriteLine("Продолжаем, Всё в порядке");
        }

        public void PullTurnip()
        {
            System.Console.WriteLine("Проверяем на количество людей\n");
            if (_Family.Count() == 6)
            {
                System.Console.WriteLine("Начинаем тянуть репку");
                foreach (var people in _Family)
                {
                    people.Pull();
                }
                System.Console.WriteLine("\nВытянули репку");
            }
            else System.Console.WriteLine("У вас недостаток либо переизбыток членов семьи");
        }
    }
}