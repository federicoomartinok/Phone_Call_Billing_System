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
            Console.WriteLine("Monthly Bill:");
            Console.WriteLine("Monthly Subscription: $" + Subscription.Cost);

            double totalLocal = LocalCalls.Sum(call => call.CalculateCost());
            Console.WriteLine("Total Local Calls: $" + totalLocal);

            double totalNational = NationalCalls.Sum(call => call.CalculateCost());
            Console.WriteLine("Total National Calls: $" + totalNational);

            double totalInternational = InternationalCalls.Sum(call => call.CalculateCost());
            Console.WriteLine("Total International Calls: $" + totalInternational);

            double totalBill = Subscription.Cost + totalLocal + totalNational + totalInternational;
            Console.WriteLine("Total Bill: $" + totalBill);
        }
    }
}
