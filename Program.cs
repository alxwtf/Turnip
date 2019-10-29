using System;
using System.Collections.Generic;
using System.Linq;
using Persons;

namespace Turnip
{
    class Program
    {
        static void Main(string[] args)
        {
            var Grandfather = new Grandfather();
            var Grandmother = new Grandmother();
            var Granddaughter = new Granddaughter();
            var Dog = new Dog();
            var Cat = new Cat();
            var Mouse = new Mouse();
            var Line = new List<Person> { Grandfather, Grandmother, Granddaughter, Dog, Cat, Mouse };
            var Turnip = new Turnip(Line);
            Turnip.DoubleSearch();
            Turnip.PullTurnip();
        }
    }
}
