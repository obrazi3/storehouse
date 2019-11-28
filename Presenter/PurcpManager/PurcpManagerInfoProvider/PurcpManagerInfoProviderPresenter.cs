﻿using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerInfoProviderPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IPurcpManagerInfoProviderView view;
        private IDeliveryOrderServiceForPurcpManager model;

        public PurcpManagerInfoProviderPresenter(IPurcpManagerInfoProviderView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel)
        {
            kernel = _kernel;
            view = _view;
            model = _model;

            view.Back += OnButtonBackClick;
            view.SearchProvider += OnButtonSearchClick;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonBackClick()
        {
            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }

        private void OnButtonSearchClick()
        {
            int id = view.GetProviderNumber();
            var provider = model.GetProductProvider(id);
            view.SetInfoProvider(provider);
        }
    }
}
