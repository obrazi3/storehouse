namespace Model
{
    public interface IServiceForAddingProductsInClientOrder
    {
        bool AddProduct(int productId, int numberOfProduct);
        bool RemoveProduct(int prodId);
        void SetClientOrder(ClientOrder order);
    }
}
