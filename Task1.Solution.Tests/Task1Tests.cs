using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class Task1Tests
    {
        [TestCase(null, ExpectedResult = false)]
        public bool PasswordValidationTest(string password)
        {
            PasswordValidation passwordValidation = new PasswordValidation(password);
            passwordValidation.AddCheck((PasswordValidation)=>password == null);
            return passwordValidation.Validate(password);
        }
    }
}
