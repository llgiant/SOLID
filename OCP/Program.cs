using System;
using System.Collections.Generic;
using OCPLibrary;
namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            //#endregion

            //#region test 2
            //var apple = new Product("Яблоко", Color.Green, Size.Small);
            //var tree = new Product("Дерево", Color.Green, Size.Large);
            //var house = new Product("Дом", Color.Blue, Size.Huge);
            //Product [] products =  { apple, tree, house };

            //var pf = new ProductFilter();

            //Console.WriteLine("Зеленые продукты:");

            //foreach (var p in pf.FilterByColor(products,Color.Green))
            //{
            //    Console.WriteLine($" - {p.Name} Зеленое");
            //}
            #endregion

            List<IApplicantModel> persons = new List<IApplicantModel> {
                                new PersonModel { FirstName="Victor",LastName="Liskov"},
                                new ManagerModel { FirstName="Mark",LastName="Abbat"},
                                new ExecutiveModel { FirstName="Eros",LastName="Bughala"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountsProcessor = new Accounts();
            foreach (var person in persons)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} : {employee.EmailAddress}");
            }

        }
    }




}
