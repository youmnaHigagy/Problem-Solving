using System;
using System.Collections.Generic;
using System.Linq;
using ProblemSolving.Interfaces;

namespace ProblemSolving.Problems
{
    public class BillDivision : IProblemExecution
    {

        public void Execute()
        {
            Console.WriteLine("This is the Bill Division, Enter the required data... ");
            Console.Write("Enter the bill items prices separated by comma: ");
            List<int> prices = Console.ReadLine().TrimEnd().Split(',').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Console.Write("Enter the number of the item Anna Execluded: ");
            int k = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Enter the amount Anna paid: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(bonAppetit(prices, k, b));
        }

        public static string bonAppetit(List<int> bill, int k, int b)
        {
            /*
            * Sum the bill
            * Subtract Anna's execluded item price from the bill
            * Divide on two of them
            * Subtract the division result and the amount Anna paid
            * If the result is zero, then Anna paid her amount.. Bon Appetit
            * If the result is greater than zero print, then she paid more than.. 
            */

            var billSum = bill.Sum();
            var sumExceptAnnaExeculdedItem = billSum - bill.ElementAt(k);
            var amountEachPersonShouldPay = sumExceptAnnaExeculdedItem / 2;
            var residual = b - amountEachPersonShouldPay;

            if (residual != 0)
                return residual.ToString();

            return "Bon Appetit";
        }
    }
}
