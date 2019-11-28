namespace Presenter
{
    public interface IBookerPayProviderOrderView : IBack, IView
    {
        event PayOrder PayOrder;
        int BankAccount { get; }
        int PaymentSum { get; }
    }

    public delegate bool PayOrder();
}
