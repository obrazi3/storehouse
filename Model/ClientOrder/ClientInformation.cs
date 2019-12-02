using System;

namespace Model
{
    public class ClientInformation : ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public HomeAddress Address { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ClientInformation()
        {
            Address = new HomeAddress();
        }

        public object Clone()
        {
            ClientInformation info = new ClientInformation();
            info.Name = (string)this.Name.Clone();
            info.Surname = (string)this.Surname.Clone();
            info.Patronymic = (string)this.Patronymic.Clone();
            info.Address = (HomeAddress)this.Address.Clone();
            info.EmailAddress = (string)this.EmailAddress.Clone();
            info.PhoneNumber = (string)this.PhoneNumber.Clone();

            return info;
        }
    }
}
