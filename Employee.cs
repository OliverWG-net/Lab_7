namespace Lab_7
{
    internal class Employee
    {
        public string _id { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public decimal _salary { get; set; }

        public Employee()
        {
            _id = "Unknown";
            _name = "Unknown";
            _gender = "Unknown";
            _salary = 0;
        }

        public Employee(string id, string name, string gender, decimal salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }

        public override string ToString()
        {
            return $"ID:{_id}, Name: {_name}, Gender: {_gender}, Salary: {_salary}:kr";
        }
    }
}