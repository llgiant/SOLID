﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@yorocorp.kg";

            return output;
        }
    }
}
