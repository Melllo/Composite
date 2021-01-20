using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of family members");

            Person grandmother = new Female("Yadviga", 3500);
            Person grandfather = new Male("Andrey", 3000);

            Person father = new Male("Yura", 2000);
            Person mother = new Male("Tany", 8000);

            Person elderSister = new Female("Ira", 1300);
            Person youngerSister = new Female("Vika", 0);

            GeneologyComposite firstGeneration = new GeneologyComposite();
            GeneologyComposite secondGeneration = new GeneologyComposite();
            GeneologyComposite thirdGeneration = new GeneologyComposite();

            firstGeneration.addMember(grandfather);
            firstGeneration.addMember(grandmother);
            firstGeneration.addMember(secondGeneration);

            secondGeneration.addMember(thirdGeneration);
            secondGeneration.addMember(father);
            secondGeneration.addMember(mother);

            thirdGeneration.addMember(elderSister);
            thirdGeneration.addMember(youngerSister);

      

            GeneologyComposite family = new GeneologyComposite();
            family.addMember(firstGeneration);
            family.BornAndExist();
            Console.WriteLine("Budget of family:");
            Console.WriteLine(firstGeneration.Budget);


            

        }
    }
}
