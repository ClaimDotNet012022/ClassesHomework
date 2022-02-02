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
        public string Species { get; set; } = "unknown";
        public bool IsSitting { get; protected set; }
        public string Breed { get; protected set; }
        public int Age { get; protected set; } = 1;


        public Animal()
        {
            Species = "unknown";
        }

        public virtual string Speak()
        {
            return "What am I?";
        }

        public bool Sit()
        {
            IsSitting = true;
            return IsSitting;
        }

        public bool Stand()
        {
            IsSitting = false;
            return IsSitting;
        }

        public int CelebrateBirthday()
        {
            Age++;
            return Age;
        }



    }
}
