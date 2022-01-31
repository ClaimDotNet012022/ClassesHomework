using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // write your Animal class here. 
    class Animal
    {
        public string Breed { get; protected set; }
        public int Age { get; protected set; }
        public string Species { get; protected set; }
        public bool IsSitting { get; protected set; }

        public virtual string Speak()
        {
            return "What am I?";
        }


    }
}
