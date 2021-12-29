using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stallproblem
{
    interface Stall
    {
        void display();
    }
    class GoldStall : Stall
    {
        public string StallName { get; private set; }
        public int Cost { get;private set; }
        public string OwnerName { get; private set; }
        public int TvSet { get; private set; }
         public GoldStall(string stallName, int cost, string ownerName, int tvSet)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.TvSet = tvSet;
        }
        public void display()
        {
            Console.WriteLine($"StallName : {StallName}");
            Console.WriteLine($"Cost : {Cost}");
            Console.WriteLine($"OwnerName : {OwnerName}");
            Console.WriteLine($"Number of TV Set : {TvSet}");
        }

    }

    class PremiumStall : Stall
    {
        public string StallName { get; private set; }
        public int Cost { get;private set; }
        public string OwnerName { get; private set; }
        public int Projector { get; private set; }
        
        public PremiumStall(string stallName, int cost, string ownerName, int projector)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.Projector = projector;
        }
        public void display()
        {
            Console.WriteLine($"StallName : {StallName}");
            Console.WriteLine($"Cost : {Cost}");
            Console.WriteLine($"OwnerName : {OwnerName}");
            Console.WriteLine($"Number of Projectors : {Projector}");
        }
    }

    class ExecutiveStall : Stall
    {
        public string StallName { get; private set; }
        public int Cost { get; private set; }
        public string OwnerName { get; private set; }
        public int Screen { get; private set; }
        public ExecutiveStall(string stallName, int cost, string ownerName, int screen)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.Screen = screen;
        }
        public void display()
        {
            Console.WriteLine($"StallName : {StallName}");
            Console.WriteLine($"Cost : {Cost}");
            Console.WriteLine($"OwnerName : {OwnerName}");
            Console.WriteLine($"Number of Screens : {Screen}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChooseStall Type");
            Console.WriteLine("1)Gold Stall");
            Console.WriteLine("2)Premium Stall");
            Console.WriteLine("3)Executive Stall");
            int option;
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    GoldStall g = new GoldStall("The Mechanic", 120000, "Johnson", 10);
                    g.display();
                    break;
                case 2:
                    PremiumStall p = new PremiumStall("Knitting plaza", 300000, "Zain", 20);
                    p.display();
                    break;
                default:
                    ExecutiveStall e = new ExecutiveStall("Fruits Hunt", 10000, "Uber", 7);
                    e.display();
                    break;
            }
            Console.ReadLine();
        }
    }
}
