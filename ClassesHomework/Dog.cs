using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    //Write your dog class here.
    class Dog : Animal
    {
        public string Breed { get; }
       

        public override string Species { get; } = "dog";


        public Dog()
        {

        }

        public Dog(string breed)
        {
            Breed = breed;
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

    }
}
