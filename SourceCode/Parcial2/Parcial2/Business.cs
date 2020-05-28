namespace Parcial2
{
    class Business
    {
        private int idBusiness;
        private string name;
        private string description;

        public Business()
        {
        }

        public Business(int idBusiness, string name, string description)
        {
            this.idBusiness = idBusiness;
            this.name = name;
            this.description = description;
        }

        public int IdBusiness
        {
            get => idBusiness;
            set => idBusiness = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}