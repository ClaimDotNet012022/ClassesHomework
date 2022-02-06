using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your dog class here.
    class Dog : Animal
    {

        public Dog()
        {
            Age = 1;
            Species = "dog";
            IsSitting = false;
        }

        public Dog(string breed)
        {
            Age = 1;
            this.Breed = breed;
        }

        public Dog(string breed, int age)
        {
            Breed = breed;
            Age = age;
        }
        
        public override string Speak()
        {
            return "woof!";
        }

        public string Speak(string toSpeak)
        {
            // string woof = toSpeak; *this is redundant*
            return toSpeak;
        }

    }

}
