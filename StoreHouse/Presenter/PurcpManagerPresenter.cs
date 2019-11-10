﻿using Ninject;

namespace Presenter
{
    public class PurcpManagerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IPurcpManagerView _view;

        public PurcpManagerPresenter(IKernel kernel, IPurcpManagerView view)
        {
            _kernel = kernel;
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
