using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frequency and Effects of Changes

            //The argument for the single responsibility principle is relatively simple:
            //    it makes your software easier to implement 
            //    and prevents unexpected side - effects of future changes.
            //requirements change over time and changes the responsibility of at least one class
            //more responsibilities more to change

            // Easier to Understand
            //Classes, software components and microservices that have only one responsibility are much easier to explain, understand and implement than the ones that provide a solution for everything
            //reduces the number of bugs
            //improves your development speed

            //not oversimplify your code
            //by creating classes with just one function
            //then you have to inject many dependencies which makes the code very unreadable and confusing
            //Therefore, the single responsibility principle is an important rule to make your code more understandable but don’t use it as your programming bible. Use common sense when developing code. There is no point in having multiple classes that just contain one function.

            //A Simple Question to Validate Your Design
            //What is the responsibility of your class/component/microservice?
            //If your answer includes the word “and”, you’re most likely breaking the single responsibility principle.

            Journal j = new Journal();
            j.AddEntry("Сегодня прекрасный день");  
            j.AddEntry("Single responsibility principle");
            PersistanceManager persistanceManager = new PersistanceManager();
            persistanceManager.SaveToFile(j, "Filename", true);
        }
    }
}
