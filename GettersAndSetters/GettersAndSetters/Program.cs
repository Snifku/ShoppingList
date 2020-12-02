using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                Name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;
            }
            public void ChangeName(string newName)
            {
                name = newName;
            }
            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "undefined unicorn";
                    }
                }
            }
            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if (value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "undefined";
                    }
                }
            }
        }

        
        static void Main(string[] args)
        {
            Person newPerson = new Person("Harry Potter", "gmail", 35, "1234");
            //Console.WriteLine(newPerson.Age);
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            //newPerson.Name = "Harry Potter";
            //newPerson.Gender = "male";
            //newPerson.Age = 21;
            //Console.WriteLine(newPerson.Age);
           // Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.Name);
            newPerson.Name = "Harry LSD";
            newPerson.ChangeName("Harry LSD");
        }
    }
}
