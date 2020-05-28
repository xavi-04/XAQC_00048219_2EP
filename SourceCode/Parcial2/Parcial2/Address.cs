namespace Parcial2
{
    class Address
    {
        private int idAddress;
        private int idUser;
        private string address;

        public Address()
        {
        }

        public Address(int idAddress, int idUser, string addreess)
        {
            this.idAddress = idAddress;
            this.idUser = idUser;
            this.address = addreess;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string Addreess
        {
            get => address;
            set => address = value;
        }
    }
}