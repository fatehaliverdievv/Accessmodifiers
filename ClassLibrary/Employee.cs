namespace ClassLibrary
{
    public class Employee
    {
        string _name;
        string _surname;
        int _salary;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[0]) && char.IsLetter(value[i]) && value.Length > 2 && value.Length < 15)
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Name!!");
                        break;
                    }
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[0]) && char.IsLetter(value[i]) && value.Length>2 && value.Length<15)
                    {
                        _surname = value;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Surname!!");
                        break;
                    }
                }
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Wrong Salary!!");
                }
            }
        }
        public Employee(string name,string surname,int salary=250)
        {
            Salary = salary;
            Name = name;
            Surname = surname;
        }
    }
}
