﻿
namespace Model
{
    public class ClientInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public HomeAddress Address { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ClientInformation() { }
    }
}
