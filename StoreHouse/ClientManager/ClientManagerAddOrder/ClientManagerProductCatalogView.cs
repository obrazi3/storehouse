using System;
using System.Windows.Forms;
using Presenter;
using Model;
using System.Collections.Generic;

namespace View
{
    public partial class ClientManagerProductCatalogView : Form, IClientManagerProductCatalogView
    {
        public event Action ProductChecked;
        public event Action Back;

        private ApplicationContext _context;
        private ProductCharacteristic _characteristic;

        public ClientManagerProductCatalogView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void SetCatalog(
            SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> productCatalog)
        {
            List<TreeNode> categories = new List<TreeNode>();
            foreach (var categoryPair in productCatalog)
            {
                List<TreeNode> groups = new List<TreeNode>();
                string category = categoryPair.Key;
                foreach (var groupPair in categoryPair.Value)
                {
                    List<TreeNode> products = new List<TreeNode>();
                    string group = groupPair.Key;
                    foreach (var product in groupPair.Value)
                    {
                        TreeNode productNode = new TreeNode();
                        productNode.Tag = product;
                        productNode.Text = product.ProductName + "          " + "Стоимость: " + product.Price +
                                           " рублей(-я)";
                        products.Add(productNode);
                    }

                    groups.Add(new TreeNode(group, products.ToArray()));
                }

                categories.Add(new TreeNode(category, groups.ToArray()));
            }


            TreeView catalogTree = new TreeView();
            catalogTree.Location = new System.Drawing.Point(4, 25);
            catalogTree.Size = new System.Drawing.Size(635, 632);
            catalogTree.Nodes.AddRange(categories.ToArray());
            catalogTree.CheckBoxes = true;
            catalogTree.AfterCheck += AfterCheck;
            GroupBoxCatalog.Controls.Clear();
            GroupBoxCatalog.Controls.Add(catalogTree);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public ProductCharacteristic GetProductCharacteristic()
        {
            return _characteristic;
        }

        private void AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                _characteristic = (ProductCharacteristic)e.Node.Tag;
                ProductChecked.Invoke();
            }
        }

        private void OnButtonAddProductsClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
