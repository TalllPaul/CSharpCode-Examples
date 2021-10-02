using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersDemo
{
    public class Person
    {

        private DateTime _birthdate;

        //You could also declare the field public and set the setter to private.  (auto implemented properties) They are set as private automatically

        public string Name { get; set; }

        //You can also use properties instead of writing out getters and setters for each field.

        private DateTime _birthdate2;

        public DateTime Birthdate
        {
            get { return _birthdate2;  }
            set { _birthdate2 = value; }
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }



        public Person()
        {
            this.Name = "Paul";
        }

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }


        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

    }
}
