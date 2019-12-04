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

        private ApplicationContext context;
        private ProductCharacteristic characteristic;

        public ClientManagerProductCatalogView(ApplicationContext _context)
        {
            context = _context;
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


            TreeView CatalogTree = new TreeView();
            CatalogTree.Location = new System.Drawing.Point(4, 25);
            CatalogTree.Size = new System.Drawing.Size(635, 632);
            CatalogTree.Nodes.AddRange(categories.ToArray());
            CatalogTree.CheckBoxes = true;
            CatalogTree.AfterCheck += AfterCheck;
            GroupBoxCatalog.Controls.Clear();
            GroupBoxCatalog.Controls.Add(CatalogTree);
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public ProductCharacteristic GetProductCharacteristic()
        {
            return characteristic;
        }

        private void AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                characteristic = (ProductCharacteristic)e.Node.Tag;
                ProductChecked.Invoke();
            }
        }

        private void OnButtonAddProductsClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
