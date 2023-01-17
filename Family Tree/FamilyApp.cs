using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree
{

    public class FamilyApp
    {
        public List<Person> _people { get; set; }

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        public string WelcomeMessage()
        {
            return "Welcome to the family tree app";
        }

        public string CommandPrompt()
        {
            return "Welcome to family app to show the detail of a person please write " +
                   "vis followed by the person's name or id number (vis 3)(vis David)\n";
        }

        public string HandleCommand(string command)
        {
            string[] commandArgs = command.Split(' ');
            if (commandArgs[0].ToLower() == "vis")
            {
                foreach (var person in _people)
                {
                    if (person.FirstName == commandArgs[1] || person.Id.ToString() == commandArgs[1])
                    {
                        return person.GetDescription(true) + GetChildren(person);
                    }
                }

                return "Person not found";
            }

            return "unknown command";
        }

        public string GetChildren(Person person)
        {
            string children = "\n  Barn:\n";
            foreach (var Person in _people)
            {
                if (Person.Mother == person || Person.Father == person)
                {
                    children += $"    {Person.GetDescription(false)}\n";
                }
            }
            return children;
        }
    }
}
