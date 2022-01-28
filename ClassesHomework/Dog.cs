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
        //properties/variables for the class
        //public string Breed      { get; private set; }
        //public int    Age        { get; private set; }
        //public bool   IsSitting  { get; private set; }


        public Dog() //default constructor
        {
            Age = 1;
            IsSitting = false;
            Species = "dog";
        }

        public Dog(string breed)
        {
            Breed = breed;
            Age = 1;
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

        public string Speak(string message)
        {
            return message;
           
        }






    }
}
