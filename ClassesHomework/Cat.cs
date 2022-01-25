using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your Cat class here
    class Cat : Animal
    {
        public Cat()
        {
            Species = "cat";
        }

        public override string Speak()
        {
            return "meow!";
        }

    }

}
