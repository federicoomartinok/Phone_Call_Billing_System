namespace Entrevista_Tecnica_Mercap
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Simulated data for a monthly bill
            List<LocalCall> localCalls = new List<LocalCall>
            {
                new LocalCall(new DateTime(2024, 3, 1, 10, 0, 0), 30),
                new LocalCall(new DateTime(2024, 3, 5, 19, 0, 0), 20),
                new LocalCall(new DateTime(2024, 3, 15, 8, 30, 0), 15)
            };

            List<NationalCall> nationalCalls = new List<NationalCall>
            {
                new NationalCall("Buenos Aires", 25),
                new NationalCall("Cordoba", 18)
            };

            List<InternationalCall> internationalCalls = new List<InternationalCall>
            {
                new InternationalCall("United States", 10),
                new InternationalCall("Spain", 15)
            };

            MonthlySub subscription = new MonthlySub(50);

            PhoneBill bill = new PhoneBill(localCalls, nationalCalls, internationalCalls, subscription);
            bill.CreateBill();
        }
    }
}

