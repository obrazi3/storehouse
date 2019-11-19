
namespace Model
{
    class ProductCharacteristic
    {
        public string ProductName { get; set; }
        public Measure Measure { get; set; }
        public string ProductId { get; set; }
        public int Price { get; set; }
        public int TotalQuantityProduct { get; set; }

        public ProductCharacteristic() { }
    }
}
