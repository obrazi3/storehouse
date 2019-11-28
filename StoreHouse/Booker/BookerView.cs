using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class BookerView : Form, IBookerView
    {
        public event Action CheckClientPayment;
        public event Action PayOrderProvider;

        private readonly ApplicationContext _context;
        public BookerView(ApplicationContext context)
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
