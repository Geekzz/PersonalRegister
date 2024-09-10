namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonalRegister> list = new List<PersonalRegister>();

            Console.WriteLine("Personal register program");

            while (true)
            {
                Console.WriteLine("Enter för att fortsätta, ESC för att avsluta");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                string? personal_name;
                while (true)
                {
                    Console.Write("Ange namn: ");
                    personal_name = Console.ReadLine();

                    // checkValidName = kollar om det är valid namn, det är metod som ligger i PersonalRegister klass
                    if (PersonalRegister.checkValidName(personal_name))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fel input, var vänligen och ange ett giltigt namn utan siffror eller whitespaces");
                    }
                }

                int personal_salary;
                while (true)
                {
                    Console.Write("Ange lön: ");
                    string? salaryInput = Console.ReadLine();

                    // checkValidSalary = kollar om det är valid lön, det är metod som ligger i PersonalRegister klass
                    if (PersonalRegister.checkValidSalary(salaryInput))
                    {
                        personal_salary = int.Parse(salaryInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fel input, var vänligen och ange ett giltigt heltal för lönen");
                    }
                }

                PersonalRegister pr = new PersonalRegister(personal_name, personal_salary);
                list.Add(pr);

            }

            Console.WriteLine("\nRegistrerade personer:");
            foreach (PersonalRegister pr in list)
            {
                Console.WriteLine($"Namn: {pr.getName()} lön: {pr.getSalary()}");
            }
        }
    }
}
