namespace HighQualityMethods
{
    using System;

    internal class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;
        private int age;

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name length cannot be less than 2");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name length cannot be less than 2");
                }

                this.lastName = value;
            }
        }
        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set 
            {
                this.otherInfo = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }

                this.age = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = false;
            if (this.age > other.age)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }
}
