using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CalculateController
    {
        private readonly ICalculateService _service;

        public CalculateController()
        {
           _service= new CalculateService();
        }
        public void MultiplyArrayItems() => Console.WriteLine(_service.MultiplyArrayItems(GetArray()));
        public void SquareOfSumArrayItems() => Console.WriteLine(_service.SquareOfSumArrayItems(GetArray()));       
        private int[]GetArray() => new[] { 1, 2, 3, 4, 5, 6, 12 };
       
    }
}
