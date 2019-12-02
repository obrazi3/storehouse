using System;

namespace Model
{
    public class HomeAddress : ICloneable
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string PavilionNumber { get; set; }
        public string PorchNumber { get; set; }
        public string FloorNumber { get; set; }
        public string FlatNumber { get; set; }

        public HomeAddress()
        {
            City = "none";
            Street = "none";
            HomeNumber = "none";
            PavilionNumber = "none";
            PorchNumber = "none";
            FloorNumber = "none";
            FlatNumber = "none";
        }

        public object Clone()
        {
            HomeAddress address = new HomeAddress();
            address.City = (string)this.City.Clone();
            address.Street = (string)this.Street.Clone();
            address.HomeNumber = (string)this.HomeNumber.Clone();
            address.PavilionNumber = (string)this.PavilionNumber.Clone();
            address.PorchNumber = (string)this.PorchNumber.Clone();
            address.FloorNumber = (string)this.FloorNumber.Clone();
            address.FlatNumber = (string)this.FlatNumber.Clone();

            return address;
        }
    }
}
