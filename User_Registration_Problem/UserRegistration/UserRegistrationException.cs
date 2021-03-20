using System;

namespace UserRegistration
{
    class UserRegistrationException : Exception
    {
        public enum ExceptionTypes
        { 
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NUMBER,
            INVALID_PASSWORD
        }
        private ExceptionTypes Type;

        public UserRegistrationException(ExceptionTypes type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
