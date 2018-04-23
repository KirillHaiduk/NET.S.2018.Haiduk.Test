using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordValidation
    {
        public List<Predicate<string>> passwordCheckers;

        private string password;

        public PasswordValidation(string password)
        {
            this.password = password;
            passwordCheckers = new List<Predicate<string>>();
        }

        public bool Validate(string password)
        {
            foreach(var condition in passwordCheckers)
            {
                if (condition(password)) return false;            
            }
            return true;
        }

        public void AddCheck(Predicate<string> condition)
        {
            passwordCheckers.Add(condition);
        }

        public void RemoveCheck(Predicate<string> condition)
        {
            passwordCheckers.Remove(condition);
        }
    }
}

//if (password == null)
//                throw new ArgumentException($"{password} is null arg");

//            if (password == string.Empty)
//                return Tuple.Create(false, $"{password} is empty ");

//            // check if length more than 7 chars 
//            if (password.Length <= 7)
//                return Tuple.Create(false, $"{password} length too short");

//            // check if length more than 10 chars for admins
//            if (password.Length >= 15)
//                return Tuple.Create(false, $"{password} length too long");

//            // check if password conatins at least one alphabetical character 
//            if (!password.Any(char.IsLetter))
//                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

//            // check if password conatins at least one digit character 
//            if (!password.Any(char.IsNumber))
//                return Tuple.Create(false, $"{password} hasn't digits");
