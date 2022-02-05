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
        public bool IsSitting { get; private set; } = false;
        public virtual string Species { get; } = "unknown";


        public virtual string Speak()
        {
            return "What am I?";
        }

        public string Speak(string message)
        {
            return message;
        }

        public void Sit()
        {
            IsSitting = true;
        }

        public void Stand()
        {
            IsSitting = false;
        }

        public void CelebrateBirthday()
        {
            Age++;
        }
    }
}
