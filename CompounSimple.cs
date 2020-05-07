using System;
namespace Question1
{
    public class CompounSimple
    {
        public string Name{ get; set; }
        public string Address{ get; set; }
        public decimal principal { get; set; }
        public int times { get; set; }
        public double rates { get; set; }


        public CompounSimple(string name, string address, decimal amount, int time, double rate )
        {
           Name = name;
           Address = address;
           Principal = amount;
           Time = time;
           Rate = rate;
        }

        public decimal Principal
        {
            get{return principal;}
            set{
                if(value > 0)
                {
                    principal = value;
                }
            }
        }

         public double Rate
        {
            get{return rates;}
            set{
                if(value > 0)
                {
                    rates = value;
                }
            }
        }

         public int Time
        {
            get{return times;}
            set{
                if(value > 0)
                {
                    times = value;
                }
            }
        }

    }

    

    
}