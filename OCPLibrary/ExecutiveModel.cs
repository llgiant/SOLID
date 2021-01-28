using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class ExecutiveModel : IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
