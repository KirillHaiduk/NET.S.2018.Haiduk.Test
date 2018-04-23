using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class Task1Tests
    {
        [TestCase(null, ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("abc123", ExpectedResult = false)]
        [TestCase("abcdefgh123456789", ExpectedResult = false)]
        [TestCase("1234567890", ExpectedResult = false)]
        [TestCase("abcdefghij", ExpectedResult = false)]
        [TestCase("abcdef123", ExpectedResult = true)]
        [TestCase("0AaBbCc1", ExpectedResult = true)]
        public bool PasswordValidationTest(string password)
        {
            var conditions = new List<Tuple<Predicate<string>, string>>();            
            Tuple<Predicate<string>, string> t1 = Tuple.Create<Predicate<string>, string>((p) => password == null, $"{password} is null arg");
            conditions.Add(t1);

            Tuple<Predicate<string>, string> t2 = Tuple.Create<Predicate<string>, string>((p) => password == string.Empty, $"{password} is empty");
            conditions.Add(t2);

            Tuple<Predicate<string>, string> t3 = Tuple.Create<Predicate<string>, string>((p) => password.Length <= 7, $"{password} length too short");
            conditions.Add(t3);

            Tuple<Predicate<string>, string> t4 = Tuple.Create<Predicate<string>, string>((p) => password.Length >= 15, $"{password} length too long");
            conditions.Add(t4);

            Tuple<Predicate<string>, string> t5 = Tuple.Create<Predicate<string>, string>((p) => !password.Any(char.IsLetter), $"{password} hasn't alphanumerical chars");
            conditions.Add(t5);

            Tuple<Predicate<string>, string> t6 = Tuple.Create<Predicate<string>, string>((p) => !password.Any(char.IsNumber), $"{password} hasn't digits");
            conditions.Add(t6);

            var passwordValidation = new PasswordValidation(password, conditions);
            return passwordValidation.Validate(password);
        }
    }
}