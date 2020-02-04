using System;

namespace Presenter
{
    public interface IPurcpManagerAddOrderFirstStepView : IView, IBack
    {
        string OrganizationName { get; set; }
        string BankAccount { get; set; }
        string ContactNumber { get; set; }
        string Email { get; set; }

        event Action NextStep;
    }
}
