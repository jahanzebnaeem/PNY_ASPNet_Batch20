namespace PNY.ASPNET20.Common
{
    public class ContactNumber
    {
        public int ID { get; set; }
        public ContactType ContactType { get; set; }
        // +92-300-1234567 +92-423-1234567
        // 92 300 1234567
        public int CountryCode { get; set; }
        public int NetworkCode { get; set; }
        public int Number { get; set; }

    }
}