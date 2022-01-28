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
        public string Species   { get; set; } = "unknown";
        public string Breed     { get; protected set; }
        public int    Age       { get; protected set; } = 1;
        public bool   IsSitting { get; protected set; }
        

        public Animal()
        {
            //Species = "unknown";
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
            return Age += 1;
        }



    }
}
