using System;

namespace Greetings
{
    class Program
    {
        static void Main()
        {
            Personcs testPersonA = new Personcs();
            Personcs testPersonB = new Personcs("Jonathan");
            Doctor testDoctorA = new Doctor();
            Doctor testDoctorB = new Doctor("Isabella");

            testPersonA.SayGreeting();
            testPersonB.SayGreeting();
            testDoctorA.SayGreeting();
            testDoctorB.SayGreeting();
        }
    }
}