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
        public int Age { get; protected set; } = 1;
        public string Breed { get; protected set; }
        public bool IsSitting { get; protected set; }
        public string Species { get; set; } = "unknown";

        public Animal()
        {
            string unknown = "unknown";
            Species = unknown;
        }

        public virtual string Speak()
        {
            return "What am I?";
        }

        public bool Sit()
        {
            return IsSitting = true;
        }

        public bool Stand()
        {
            return IsSitting = false;
        }

        public int CelebrateBirthday()
        {
            return Age++;
        }

    }



}
