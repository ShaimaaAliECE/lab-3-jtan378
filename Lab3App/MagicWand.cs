using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description)
        {
            Description = description;
        }

        public override void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine($"{Description} is Used");
        }
    }
}