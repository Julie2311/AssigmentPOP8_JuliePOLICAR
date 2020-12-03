using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentPOP8_JuliePOLICAR
{
    public class Person
    {
        // Instance variables
        internal string firstname;
        internal string lastname;

        // Constructor
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        // Properties
        public string FName
        {
            get { return firstname; }
            set
            {
                firstname = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name is empty !");
                }
            }
        }

        public string Lname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name is empty !");
                }
            }
        }



    }
}
