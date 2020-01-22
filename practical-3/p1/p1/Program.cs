using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.setDetails();
            c.getInfo();
            Console.ReadKey();
        }
    }
    abstract class Car
    {
        public int carno;
        public String name;
        public abstract void getCarInfo();
    }
    interface Rate
    {
        void getDays();
        void getKm();
    }
    class Customer:Car,Rate
    {
        String nm,s,d;
        int days;
        double km;
        double total=0;
        double rate_km = 7.5;
        double rate_days = 500;
        public void setDetails()
        {
            Console.WriteLine("Enter Name : ");
            nm = Console.ReadLine();
            Console.WriteLine("Enter Source Station Name : ");
            s = Console.ReadLine();
            Console.WriteLine("Enter Destination Station Name : ");
            d = Console.ReadLine();
            Console.WriteLine("Enter Car Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Car No : ");
            carno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No of days : ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No of Km : ");
            km = Convert.ToDouble(Console.ReadLine());
        }
        public void getDays()
        {
            Console.WriteLine("Total Days :"+days);
        }
        public void getKm()
        {
            Console.WriteLine("Total Km : "+km);
        }
        public void calRate()
        {
            total = km * rate_km;
            total += days * rate_days;
        }
        public void getInfo()
        {
            calRate();
            Console.WriteLine();
            Console.WriteLine("Customer Name : " + nm);
            Console.WriteLine("Source Station Name : " + s);
            Console.WriteLine("Destination Station Name : " + d);
            getCarInfo();
            getDays();
            getKm();
            Console.WriteLine("Total Amount :"+total);
        }
        public override void getCarInfo()
        {
            Console.WriteLine("Car Name : "+name);
            Console.WriteLine("Car No :"+carno);
        }
    }
}
