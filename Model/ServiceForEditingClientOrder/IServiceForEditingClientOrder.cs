﻿namespace Model
{
    public interface IServiceForEditingClientOrder
    {
        void AddClientOrder(ClientOrder order);
        void ConfirmCompletionEditing(int orderId);
        void CancelEditing(int orderId);
        void AddProduct(int orderId, int productId, int numberOfProduct);
        void RemoveProduct(int orderId, int productId);
        
    }
}
