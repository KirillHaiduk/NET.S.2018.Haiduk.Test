using System;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        private PasswordValidation passwordValidation;
        
        public PasswordCheckerService(IRepository repository, PasswordValidation passwordValidation)
        {
            this.repository = repository;
            this.passwordValidation = passwordValidation;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (passwordValidation.Validate(password))
            {
                repository.Create(password);

                return Tuple.Create(true, "Password is Ok. User was created");
            }
            else
            {
                throw new ArgumentException($"{password} is incorrect");
            }
        }
    }
}
