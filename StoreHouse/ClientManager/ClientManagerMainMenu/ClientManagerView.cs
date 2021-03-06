﻿using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class ClientManagerView : Form, IClientManagerView
    {
        public event Action AddOrder;
        public event Action LookOrder;
        public event Action ShowOrders;
        public event Action Back;

        private readonly ApplicationContext _context;
        public ClientManagerView(ApplicationContext context)
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

        private void OnButtonAddOrderClick(object sender, EventArgs e)
        {
            AddOrder?.Invoke();
        }

        private void OnButtonLookOrderClick(object sender, EventArgs e)
        {
            LookOrder?.Invoke();
        }

        private void OnButtonExitClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonShowOrderClick(object sender, EventArgs e)
        {
            ShowOrders?.Invoke();
        }
    }
}
