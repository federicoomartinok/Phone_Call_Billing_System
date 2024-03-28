namespace Entrevista_Tecnica_Mercap
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Simulacion de los datos
            List<LocalCall> localCalls = new List<LocalCall>
            {
                new LocalCall(new DateTime(2024, 3, 1, 8,0,0), 30),
                new LocalCall(new DateTime(2024, 2, 5, 12,0,0), 1),
                new LocalCall(new DateTime(2024, 6, 15, 5,0,0), 1)
            };

            List<NationalCall> nationalCalls = new List<NationalCall>
            {
                new NationalCall("Buenos Aires", 25, new DateTime(2024,5,6)),
                new NationalCall("Cordoba", 18,new DateTime(2024, 2, 20))
            };
            
            List<InternationalCall> internationalCalls = new List<InternationalCall>
            {
                new InternationalCall("Uruguay", 10,new DateTime(2024,9,6)),
                new InternationalCall("Brasil", 15,new DateTime(2024,9,6)),
                new InternationalCall("China",8,new DateTime(2024,2,6))
            };            
            MonthlySub subscription = new MonthlySub(50);

            PhoneBill bill = new PhoneBill(localCalls, nationalCalls, internationalCalls, subscription);

            bill.CreateBill();
        }
    }
}

