using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksystem
{
    interface Bank
    {
        void InterestCalc(int a);
    }

    class Deposit : Bank
    {
        string Customer;
        double Balance;
        float Rate;

        public Deposit(string customer,double balance,float rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Rate = rate;
        }

        public void InterestCalc(int months)
        {
            float res = 0;
            if (Balance>0 && Balance<1000)
            {
                Console.WriteLine($"Interest rate : {res}");
            }
            else
            {
                res = months * Rate;
                Console.WriteLine($"Interest rate : {res}");
            }
            
          
        }



    }
    class Loan : Bank
    {
        string Customer;
        double Balance;
        float Rate;

        public Loan (string customer, double balance, float rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Rate = rate;
        }

        public void InterestCalc(int months)
        {
            float res = 0;
            if ((Customer== "Individual")&&(months<3))
            {
                Console.WriteLine($"Interest rate : {res}");
            }
            else if ((Customer == "Company") && (months < 2))
            {
                Console.WriteLine($"Interest rate : {res}");
            }
            else
            {
                if (Customer == "Individual")
                {
                    months = months - 3;
                    res = months * Rate;
                    Console.WriteLine($"Interest rate : {res}");
                }
                else
                {
                    months = months - 2;
                    res = months * Rate;
                    Console.WriteLine($"Interest rate : {res}");

                }
                    
            }


        }


    }
    class Mortage : Bank
    {
        string Customer;
        double Balance;
        float Rate;
        public Mortage(string customer, double balance, float rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Rate = rate;
        }

        public void InterestCalc(int months)
        {
            float res = 0;
            if ((Customer == "Individual") && (months < 6))
            {
                Console.WriteLine($"Interest rate : {res}");
            }
            else if ((Customer == "Company") && (months < 12))
            {
                res = (months * Rate)/2;
                Console.WriteLine($"Interest rate : {res}");
            }
            else
            {
                if (Customer == "Individual")
                {
                    months = months - 6;
                    res = months * Rate;
                    Console.WriteLine($"Interest rate : {res}");
                }
                else
                {
                    res = (12 * Rate) / 2;
                    months = months - 12;
                    res += months * Rate;
                    Console.WriteLine($"Interest rate : {res}");

                }

            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Types Of Accounts :");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Deposit Account");
            Console.WriteLine("2. Loan Account");
            Console.WriteLine("3. Mortage Account");

            int accountType;
            accountType = Convert.ToInt32(Console.ReadLine());

            switch(accountType)
            {
                case 1:
                    double bal;
                    float ir;
                    int m;
                    Console.Write("Enter Balance :");
                    bal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Interest Rate :");
                    ir = float.Parse(Console.ReadLine());
                    Deposit d = new Deposit("Individual", bal, ir);
                    Console.Write("Enter No.Of.Months :");
                    m = Convert.ToInt32(Console.ReadLine());
                    d.InterestCalc(m);
                    break;
                case 2:
                    double b;
                    float i;
                    string acc;
                    int m1;
                    Console.Write("Enter Balance :");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Interest Rate :");
                    i = float.Parse(Console.ReadLine());
                    Console.WriteLine("Choose Account Type :");
                    Console.WriteLine("1.Individual");
                    Console.WriteLine("2.Company");
                    int no;
                    no = Convert.ToInt32(Console.ReadLine());
                    if(no==1)
                    {
                        acc = "Individual";
                    }
                    else
                    {

                        acc = "Company";
                    }
                    Loan l = new Loan(acc, b, i);
                    Console.Write("Enter No.Of.Months :");
                    m1 = Convert.ToInt32(Console.ReadLine());
                    l.InterestCalc(m1);
                    break;
                case 3:
                    double b1;
                    float i1;
                    string acc1;
                    int m2;
                    Console.Write("Enter Balance :");
                    b1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Interest Rate :");
                    i1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Choose Account Type :");
                    Console.WriteLine("1.Individual");
                    Console.WriteLine("2.Company");
                    int no1;
                    no1 = Convert.ToInt32(Console.ReadLine());
                    if (no1 == 1)
                    {
                        acc1 = "Individual";
                    }
                    else
                    {

                        acc1 = "Company";
                    }
                    Mortage mo = new Mortage(acc1, b1, i1);
                    Console.Write("Enter No.Of.Months :");
                    m2 = Convert.ToInt32(Console.ReadLine());
                    mo.InterestCalc(m2);

                    break;



            }

            
            
            
           
            Console.ReadLine();

        }
    }
}
