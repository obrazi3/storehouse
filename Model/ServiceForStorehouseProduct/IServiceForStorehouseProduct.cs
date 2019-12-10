namespace Model
{
    public interface IServiceForStorehouseProduct
    {
        void SetStorehouseProduct(StorehouseProduct product);
        void AddLot(LotInformation info);
        void RemoveLot(LotInformation info);
        ProductFromLot GetProductFromLot(int number);
        void UpdateProductCharacteristic();
    }
}
