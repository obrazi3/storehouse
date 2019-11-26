using System;
using System.Collections.Generic;

namespace Presenter
{
    public interface IPurcpManagerAddProviderView : IView, IBack
    {
        event Action AddProvider;
        List<string> GetListProductCategories();
        
        string ProviderName { get; }
        string Email { get; }
        string BankAccount { get; }
        string PhoneNumber { get; }
    }
}
