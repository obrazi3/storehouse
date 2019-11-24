using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerView : Form, IPurcpManagerView
    {
        public event Action ViewInfoOrderProd;
        public event Action AddOrder;
        public event Action ViewInfoProvider;
        public event Action AddProvider;
        public event Action RemoveProvider;
        public event Action ViewInfoEndedProd;

        private readonly ApplicationContext _context;
        public PurcpManagerView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
