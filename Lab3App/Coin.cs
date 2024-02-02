using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value)
        {
            Description = description;
            Score = score;
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.UpdateTotalValue(Value);
        }

        public override void AddMe(List<Collectable> collection)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            collection.Add(this);
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}
