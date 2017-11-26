using System;
using Customer.Utils;
namespace Customer{
    class Customer {
        private FileLogger obj = new FileLogger();
        public void Add(){
            try{
                int a = 1;
                int b = 0;
                Console.WriteLine(a/b);
        }

            catch(Exception ex){
                obj.Handle(ex.ToString());
            }
        }
        public virtual double getDiscount(double TotalSales){
            return TotalSales;
        }
    }
    class SilverCustomer : Customer{
        public override double getDiscount(double TotalSales){
            return base.getDiscount(TotalSales) - 50;
        }
    }
    
    class GoldCustomer : Customer{
        public override double getDiscount(double TotalSales){
            return base.getDiscount(TotalSales) - 100;
        }
    }
}