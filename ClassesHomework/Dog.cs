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
        public Dog() : base()
        {
            Age = 1;
            IsSitting = false;
        }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public Dog(int age)
        {
            Age = age;
        }

        public Dog(bool isSitting)
        {
            IsSitting = isSitting;
        }

        public Dog(string breed, int age)
        {
            Breed= breed;
            Age = age;
           
        }

        public string Speak()
        {
            string speakDog = "woof!";
            return speakDog;
        }

        public string Speak(string sayThis)
        {
            return sayThis;
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
