using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@yoro.kg";

            return output;
        }
    }
}
