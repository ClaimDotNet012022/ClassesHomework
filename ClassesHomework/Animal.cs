using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // write your Animal class here. 
    public class Animal
    {
        public int Age { get; protected set; }
        public string Breed { get; set; }
        public bool IsSitting { get; set; }
        public string Species { get; set; }
        public bool Speaks { get; set; }
        
        
        public virtual string Speak()
        {
            string toSpeak = "what am i?";
            return toSpeak;
        }


    }
}
