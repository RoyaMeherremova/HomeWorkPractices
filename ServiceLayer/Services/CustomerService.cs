using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {

        public Customer[] GetCustomerByFiltered(int startAge, int endAge)
        {
            var arr = GetAll();
            Customer[] result = new Customer[arr.Length];
            int count = 0;
            foreach (var item in arr)
            {
                if (item.Age>startAge && item.Age<endAge)
                {
                    result[count] = item;
                    count++;
                }

            }

           return result;
        }

        public int GetCustomerCountByFiltered()
        {
            int count = 0;
            var arr = GetAll();
            foreach (var item in arr)
            {
                if (item.Age>25 && item.Age<30)
                {
                    count++;
                }
            }
            return count;
        }

        public double GetCustomersAverageByAges()
        {
            
            var arr= GetAll();
            double sumAge = 0;
            foreach (var item in arr)
            {
                sumAge+= item.Age;                
            }
            return Math.Ceiling(sumAge / arr.Length);

        }


        private Customer[] GetAll()
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Age = 25,
                Position = "Backend developer",
            };


            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimlo",
                Age = 25,
                Position = "Frontend developer",
            };

            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Aqsin",
                Surname = "Hummetov",
                Age = 27,
                Position = "Fullstack developer",
            };

            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Jale",
                Surname = "Abdullayeva",
                Age = 18,
                Position = "Software instructor",
            };

            Customer[] customers = {c1, c2, c3, c4, };
            return customers;
        }

    }
}
