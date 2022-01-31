using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    class Cat : Animal
    {
        public Cat()
        {
            IsSitting = false;
            Age = 0;

        }

        public string Breed { get; private set; }
        public int Age { get; private set; }
        public bool IsSitting { get; private set; }

        public Cat(string breed)
        {
            Breed = breed;
        }

        public Cat(int age)
        {
            Age = age;
        }

        public Cat(string breed, int age)
        {
            Breed = breed;
            Age = age;
        }

        public string Speak()
        {
            return "meow!";
        }

        public string Speak(string sayThisCat)
        {
            return sayThisCat;
        }

        public bool Sit()
        {
            return true;
        }

        public bool Stand()
        {
            return false;
        }

        public int CelebrateBirthday()
        {
            return Age++;
        }
    }

}
