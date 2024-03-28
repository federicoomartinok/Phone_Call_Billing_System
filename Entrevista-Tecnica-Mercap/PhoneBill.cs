using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public class PhoneBill
    {
        public List<LocalCall> LocalCalls { get; set; }
        public List <NationalCall> NationalCalls { get; set; }
        public List <InternationalCall> InternationalCalls { get; set; }
        public MonthlySub Subscription { get; set; }        

        public PhoneBill(List<LocalCall> localCalls, List<NationalCall> nationalCalls,
            List<InternationalCall> internationalCalls, MonthlySub subscription)
        {
            LocalCalls = localCalls;
            NationalCalls = nationalCalls;
            InternationalCalls = internationalCalls;
            Subscription = subscription;
        }

        public void CreateBill()
        {
            Console.WriteLine("Enter the month in numeric format: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int month) && month >= 1 && month <= 12)
            {
                // Crear un objeto DateTime con el mes ingresado y el año actual
                DateTime specificMonth = new DateTime(DateTime.Now.Year, month, 1);
                Console.WriteLine("Monthly Bill - " + specificMonth.ToString("MMMM yyyy"));
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Monthly Subscription: $" + Subscription.Cost);

                double totalLocal = LocalCalls.Where(call => call.Date.Month == month)
                                              .Sum(call => call.CalculateCost());
                Console.WriteLine("Total Local Calls: $" + totalLocal);

                double totalNational = NationalCalls.Where(call => call.DateTime.Month == month)
                                                    .Sum(call => call.CalculateCost());
                Console.WriteLine("Total National Calls: $" + totalNational);

                double totalInternational = InternationalCalls.Where(call => call.DateTime.Month == month)
                                                              .Sum(call => call.CalculateCost());
                Console.WriteLine("Total International Calls: $" + totalInternational);

                double totalBill = Subscription.Cost + totalLocal + totalNational + totalInternational;
                Console.WriteLine("Total Bill: $" + totalBill);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric month.");
            }
        }
    }
}
