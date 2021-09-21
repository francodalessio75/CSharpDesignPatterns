using System;
using static DesignPatterns.Person;

namespace DesignPatterns
{
    class Program
    {
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
