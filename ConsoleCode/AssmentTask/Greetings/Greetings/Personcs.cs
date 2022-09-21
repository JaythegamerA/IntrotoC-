using System;

namespace Greetings
{
    class Personcs
    {
        protected string name;
        protected int phoneNumber = 0;
        protected string emailAddress = "";

        //default constructor
        public Personcs()
        {
            this.name = "John Doe";
        }

        //one argument constructor (name)
        public Personcs(string name)
        {
            this.name = name;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine("Hello, I'm " + name);
        }
    }

}