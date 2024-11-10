using Lab_7;

internal class Program
{
    private static void Main(string[] args)
    {
        //intierar en liste med employees
        List<Employee> liststack = new List<Employee>()
            {
                new Employee("EN 001", "Anna Khön", "Female", 22500m),
                new Employee("EN 002", "Johan Fäldt", "Male", 25500m),
                new Employee("EN 003", "Mats Andersson", "Male", 22500m),
                new Employee("EN 004", "Joakim von Anka", "Male", 24500m),
                new Employee("EN 005", "Mira Losom", "Female", 27500m),
            };
        //skapar två stackar skapar två stacks en som initieras av listan och sen en kopia av stacken
        Stack<Employee> stack = new Stack<Employee>(liststack);
        Stack<Employee> stack2 = new Stack<Employee>(stack);

        Console.WriteLine(stack.Count());

        //visar alla objekt i stacken
        foreach (Employee item in stack)
        {
            Console.WriteLine(item);
            Console.WriteLine("items left in stack: " + stack.Count() + "\n");
        }
        //tar bort object från stacken och skriver ut objektet

        while (stack.Count > 0)
        {
            Employee employeepop = stack.Pop();

            Console.WriteLine($"{employeepop._id} - {employeepop._name} - {employeepop._salary}");
            Console.WriteLine(stack2.Peek());//visar första objektet i kopian av stacken

            Console.WriteLine("Number of items left in stack: " + stack.Count() + "\n");
        }
        Console.WriteLine("----------------------------------------------------------------");

        //kollar om stack två har minst 2 objekt
        Console.WriteLine("");
        if (stack2.Count >= 2)
        {
            Employee peek = stack2.Peek();
            Console.WriteLine("First item: " + peek);
            Console.WriteLine("Number of items left in stack: " + stack2.Count());
            Console.WriteLine("");

            //tiitar på andra objektet i listan
            Employee temp = stack2.Pop();
            Employee peek2 = stack2.Peek();
            Console.WriteLine("Second item: " + peek2);
            Console.WriteLine("Number of items left in stack: " + stack2.Count());
            Console.WriteLine("");

            //lägg till det tillfäligt borttagna objekten
            stack2.Push(temp);
        }
        else
        {
            Console.WriteLine("Stack does not contain at least 2 items");
        }

        //Kontrollera om emplyees med id 003 finns i stack2
        Console.WriteLine("items left in stack :" + stack2.Count + "\n");

        Console.WriteLine("Checks if employee nr:3 is in the list.");
        bool found = false;
        foreach (Employee item in stack2)
        {
            if (item._id == "EN 003")
            {
                Console.WriteLine(item);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Employee not found");
        }

        Console.WriteLine("");

        Console.WriteLine("----------------------------------------------------------------");

        //skaoa en ny lista med employee objekt och kontrollerar om en specefik medarbetare finns
        List<Employee> emplist = new List<Employee>()
            {
                new Employee("EN 006", "Anton Andersson", "Male", 22500m),
                new Employee("EN 007", "Noah Ek", "Male", 25500m),
                new Employee("EN 008", "Joel Andersson", "Male", 22500m),
                new Employee("EN 009", "Moa Lund", "Male", 24500m),
                new Employee("EN 010", "Johanna Ström", "Female", 27500m),
            };

        //kontrollerera om employee 2 finns i listan
        bool empfinss = emplist.Contains(emplist[1]);
        if (empfinss == true)
        {
            Console.WriteLine("looking if employee nr:2 is in the list\n");
            Console.WriteLine("Employee 2 exists in list\n");
        }
        else if (empfinss == false)
        {
            Console.WriteLine("looking if employee nr:2 is in the list\n");
            Console.WriteLine("Employee 2 does not exist in list\n");
        }

        Console.WriteLine("----------------------------------------------------------------");

        //Hitta och visa alla manliga medarbetare i emplist
        Employee findemployee = emplist.Find(e => e._gender == "Male");

        Console.WriteLine("Returns the firest male emmployee found.");
        if (findemployee != null)
        {
            Console.WriteLine("Emplyee found" + findemployee + "\n");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
        Console.WriteLine("----------------------------------------------------------------");

        var genderm = emplist.FindAll(e => e._gender == "Male");
        Console.WriteLine("Reurns all male employee's");
        foreach (var item in genderm)
        {
            Console.WriteLine(item);
        }
    }
}