using System;
using System.Collections.Generic;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 2.3";
            string text = "This is a string";

            int age = 35;
            DateTime now = DateTime.Now;

            double amount = 0;

            string string2 = text + " a second string " + age + now + amount;

            string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

            string string4 = $"The age is { age }, the time is { now }, and the amount is { amount }";

            char sampleChar = 'C';

            char[] arrayChar = string4.ToCharArray();

            amount = (double)10 / (double)3;

            DateTime dateTime = new DateTime(2000, 1, 1);

            var timeStamp1 = now - dateTime;
            //var otherText = "this is a text";

            //Console.WriteLine(timeStamp1.TotalMilliseconds);

            string test = "15";

            age = int.Parse(test);

            string booleanValue = "True";

            bool isTrue = bool.Parse(booleanValue);

            List<Customer> CustomerList = new List<Customer>();
            CustomerList.Add(new Customer("Edy", new DateTime(2021, 10, 11)));
            CustomerList.Add(new Customer("Jesus", new DateTime(2021, 12, 1)));
            CustomerList.Add(new Customer("Manuel", new DateTime(2021, 10, 10)));
            CustomerList.Add(new Customer("Alejandra", new DateTime(2021, 7, 3)));
            CustomerList.Add(new Customer("Roberto", new DateTime(2021, 9, 1)));
            CustomerList.Add(new Customer("Sofia", new DateTime(2021, 2, 6)));
            CustomerList.Add(new Customer("Fernanda", new DateTime(2021, 7, 1)));
            CustomerList.Add(new Customer("Dulce", new DateTime(2021, 4, 30)));
            CustomerList.Add(new Customer("Jazmin", new DateTime(2021, 1, 22)));
            CustomerList.Add(new Customer("Nelly", new DateTime(2021, 2, 21)));

            Console.WriteLine("Using in 'foreach' bucle: ");
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine("Client: " + customer.Name + " | Register Date: " + customer.RegisterDate.ToString());
            }

            Console.WriteLine("Using in 'for' bucle: ");
            for (int i = 0; i < CustomerList.Count; i++)
            {
                Console.WriteLine("Client: " + CustomerList[i].Name + " | Register Date: " + CustomerList[i].RegisterDate.ToString());
            }

            Console.WriteLine("Using in 'while' bucle: ");
            int BucleCount = 0;
            while (CustomerList.Count != BucleCount)
            {
                Console.WriteLine("Client: " + CustomerList[BucleCount].Name + " | Register Date: " + CustomerList[BucleCount].RegisterDate.ToString());
                BucleCount++;
            }

            Console.WriteLine("Using in 'do while' bucle: ");
            BucleCount = 0;
            do
            {
                Console.WriteLine("Client: " + CustomerList[BucleCount].Name + " | Register Date: " + CustomerList[BucleCount].RegisterDate.ToString());
                BucleCount++;
            } while (BucleCount < CustomerList.Count);

            Console.ReadKey(true);


        }
    }
}
