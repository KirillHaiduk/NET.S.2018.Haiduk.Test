using System;
using System.Collections.Generic;

namespace Task1.Solution
{
    public class PasswordValidation
    {
        private string password;

        private List<Tuple<Predicate<string>, string>> passwordCheckers=new List<Tuple<Predicate<string>, string>>();

        public PasswordValidation(string password, List<Tuple<Predicate<string>, string>> newPasswordCheckers)
        {
            this.password = password;
            foreach(var checker in newPasswordCheckers)
            {
                passwordCheckers.Add(checker);
            }
        }

        public bool Validate(string password)
        {
            foreach(var condition in passwordCheckers)
            {
                if (!condition.Item1.Invoke(password)) return false;            
            }

            return true;
        }

        public void AddCheck(Tuple<Predicate<string>, string> condition)
        {
            passwordCheckers.Add(condition);
        }

        public void RemoveCheck(Tuple<Predicate<string>, string> condition)
        {
            passwordCheckers.Remove(condition);
        }
    }
}