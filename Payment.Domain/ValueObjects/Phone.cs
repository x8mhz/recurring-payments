namespace Payment.Domain.ValueObjects
{
    public class Phone
    {
        public Phone(string countryNumber, string prefixNumber, string number)
        {
            CountryNumber = countryNumber;
            PrefixNumber = prefixNumber;
            Number = number;
        }

        public string CountryNumber { get; private set; }
        public string PrefixNumber { get; private set; }
        public string Number { get; private set; }

        public override string ToString()
        {
            return $"{CountryNumber} {PrefixNumber} {Number}";
        }
    }
}