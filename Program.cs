
using System;

namespace Question1
{
    public delegate void InterestDel(decimal principal, int time, double rate);
    class Program
    {

        
        static void Main(string[] args)
        {
            
         CompounSimple simple1 = new CompounSimple("James Stuart", "James stuart Avenu", 1000m , 10 , 0.05);
         CompounSimple simple2 = new CompounSimple("James Stuart", "James stuart Avenu", 2000m , 20 , 0.01);
         object[][] customer = { new object[]{simple1.Name, simple1.Address, simple1.Principal, simple1.Time, simple1.Rate}, new object[]{simple2.Name, simple2.Address, simple2.Principal, simple2.Time, simple2.Rate}};


            Console.WriteLine("Looping Over Customers Details\n__________________");
            int count = 0;
            for (int i = 0; i < customer.Length; i++)
            {
                count++;
                for (int k = 0; k < customer[i].Length; k++)
                {
                    Console.WriteLine($"{customer[i][k], 3}");
                }
                Console.WriteLine();
                Console.WriteLine(" First Customers Interest\n_______________________________");
                InterestDel interest1 = SimpleInterest;
                interest1 += CompoundInterest;
                interest1((decimal)customer[i][2], (int)customer[i][3], (double)customer[i][4]);
                Console.WriteLine();
            }

            
            

            // Console.WriteLine(" Second Customers Interest\n________________________________");
            // InterestDel interest2 = SimpleInterest;
            // interest2 +=CompoundInterest;
            // interest2((decimal)customer[i][2], (double)customer[i][3], (int)customer[i][4]);
            
        }
        //    CompounSimple simple1 = new CompounSimple("James Stuart", "James stuart Avenu", 1000m , 10 , 0.05);
        //    //  CompounSimple simple2 = new CompounSimple("James Stuart", "James stuart Avenu", 2000m , 20 , 0.01);
        //    string Name =  CompounSimple.Name;
        //    string Address =  CompounSimple.Address;
        //    decimal Principal =  CompounSimple.Principal;
        //    int Time =  CompounSimple.Time;
        //    double Rate =  CompounSimple.Rate;


        public static  void SimpleInterest( decimal Principal, int Time, double Rate)
        {
            
            decimal simpleInterest = (Principal *(decimal)(Time * Rate)) / 100;
            string value = $"Simple interest is {simpleInterest:C}\n";
            Console.Write(value: value);
        }

        public static  void CompoundInterest(decimal Principal, int Time, double Rate)
        {

            for(int i =0; i<= Time; i++)
            {
                decimal compoundInterest = Principal * (decimal)(Math.Pow((1.0 + Rate), i));
                string value = $"Compound interest is {compoundInterest:C}\n";
                Console.Write(value: value);
            }
        }


        //  public  void CompoundInterest()
        // {

        //     for(int i =0; i<= Time; i++)
        //     {
        //         decimal compoundInterest = Principal * (decimal)(Math.Pow((1.0 + Rate), i));
        //         string value = $"Compound interest is {compoundInterest:C}\n";
        //         Console.Write(value: value);
        //     }
        // }

        //  public  void SimpleInterest()
        // {
        //     decimal simpleInterest = (Principal *(decimal)(Time * Rate)) / 100;
        //     string value = $"Simple interest is {simpleInterest:C}\n";
        //     Console.Write(value: value);
        // }




       
    }
}
