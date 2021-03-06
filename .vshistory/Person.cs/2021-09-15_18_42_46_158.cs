using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Person
    {
        public enum Relationship
        {
            Parent,
            Child,
            Sibling
        }
        public string  name { get; set; }

        public class Relationships
        {
            private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

            public void addParentAndChild(Person parent, Person child)
            {
                relations.Add((parent,Relationship.Parent,child));
                relations.Add((child,Relationship.Child,parent));
            }

            public List<(Person, Relationship, Person)> Relations => relations;
        }

        public class Research
        {
            public Research(Relationships relationships)
            {
                var relations = relationships.Relations;
                foreach (var r in relations.Where(x => x.Item1.name == "Franco" && x.Item2 == Relationship.Parent))
                {
                    Console.WriteLine($"Franco has a child called {r.Item3.name}")
                }
            }
            static void Main(string[] args)
            {
                var parent = new Person() { name = "Franco" };
                var child1 = new Person() { name = "Tommaso" };
                var child2 = new Person() { name = "Letizia" };

                var relationships = new Relationships();
                relationships.addParentAndChild(parent, child1);
                relationships.addParentAndChild(parent, child2);

                new Research(relationships);
            }

            
        }
    }
}
