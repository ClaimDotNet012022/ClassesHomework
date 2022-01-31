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
            IsSitting = false;
            Age = 0;
            
        }

        

        public Dog(string breed)
        {
            Breed = breed;
        }

        public Dog(int age)
        {
            Age = age;
        }

        public Dog(string breed, int age)
        {
            Breed= breed;
            Age = age;
        }

        public string Speak()          
        {
            return "woof!";
        }

        public string Speak(string sayThis)      
        {
            return sayThis;    
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
