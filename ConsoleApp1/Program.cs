using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = new testquestion();
            // a.playingwithforloops();
            birthday_party peter = new birthday_party();
            peter.run();


        }
    }
    /* class testquestion
     {
         public int myfavvariable = 0;
         public void playingwithforloops()
         {
             for (; mymethod();)
             {
                 if (myfavvariable > 10)
                 {
                     Console.WriteLine("I am outof  the for loop");
                     break;
                 }
                 Console.WriteLine("oh no ihave to go through this stupid loop again");
             }
         }
         public bool mymethod()
         {
             myfavvariable++;
             return true;
         }
     }*/
    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }



        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;

    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;



        public void mapini()
        {
            peanut = new dog("peanut", "bichon");
            fifi = new dog("fifi", "poodle");
            clarence = new dog("clarence", "german");
            roy = new dog("roy", "beagle");


            peanut.prev_dog = null;
            peanut.next_dog = fifi;

            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;

            clarence.prev_dog = fifi;
            clarence.next_dog = roy;

            roy.prev_dog = clarence;
            roy.next_dog = null;
            head = peanut;
            tail = roy;



        }
        public void run()
        {
            this.mapini();
            Console.WriteLine(dognames);
        }

        public void dognames()
        {
            head = peanut;
            while (temporary.next_dog != null)
            {
                Console.WriteLine(temporary.dog_name);
            }
        }
    }
}