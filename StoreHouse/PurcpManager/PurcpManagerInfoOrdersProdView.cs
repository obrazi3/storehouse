using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerInfoOrdersProdView : Form, IPurcpManagerInfoOrderProdView
    {
        public event Action Back;
        public event Action RemoveOrders;

        private Dictionary<int, CheckBox> dictionaryCheckBoxes;

        private readonly ApplicationContext context;

        public PurcpManagerInfoOrdersProdView(ApplicationContext _context)
        {
            InitializeComponent();
            context = _context;
            dictionaryCheckBoxes = new Dictionary<int, CheckBox>();
        }

        public void AddOrder(FlowLayoutPanel order, int orderNumber, CheckBox box)
        {
            this.PanelOrdersInfo.Controls.Add(order);
            dictionaryCheckBoxes.Add(orderNumber, box);
        }

        public Dictionary<int, CheckBox> GetDictionaryBoxes()
        {
            return dictionaryCheckBoxes;
        }

        public void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonRemoveOrdersClick(object o, EventArgs e)
        {
            RemoveOrders?.Invoke();
        }
    }
}
