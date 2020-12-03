namespace WebApplication.Models
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string state;
        private string country;
        private string zipCode;
        private string phoneNumber;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string State
        {
            get => state;
            set => state = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
    }
}