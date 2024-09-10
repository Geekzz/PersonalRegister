using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class PersonalRegister
    {
        private string? name;
        private int salary;

        public string? getName()
        {
            return name;
        }

        public int getSalary()
        {
            return salary;
        }

        // kollar om salary kan convertas till int, annars är det fel (lönen ska ska vara nummer, inte sträng)
        // samt att det ska vara över eller lika med 0
        public static bool checkValidSalary(string salary)
        {
            if (int.TryParse(salary, out int parsedSalary))
            {
                return parsedSalary >= 0;
            }
            return false;
        }

        public static bool checkValidName(string name)
        {
            // i namnet ska det inte gå att inkludera siffror/whitespace, till exempel Johan1 eller Joh an1 :)
            foreach (char c in name)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }
            if (!string.IsNullOrWhiteSpace(name)) {
                return true;
            }
            return false;
        }

        public PersonalRegister(string? name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
    }
}
