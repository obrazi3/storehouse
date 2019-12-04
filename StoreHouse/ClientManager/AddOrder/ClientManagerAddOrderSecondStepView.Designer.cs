using System;
using System.Threading;

namespace View
{
    partial class ClientManagerAddOrderSecondStepView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelAddProduct = new System.Windows.Forms.Panel();
            this.LabelCurrentOrderCost = new System.Windows.Forms.Label();
            this.LabelOrderCost = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxListProducts = new System.Windows.Forms.GroupBox();
            this.PanelListProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonConfirmOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonRemoveProducts = new System.Windows.Forms.Button();
            this.PanelAddProduct.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.GroupBoxListProducts.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddProduct
            // 
            this.PanelAddProduct.Controls.Add(this.LabelCurrentOrderCost);
            this.PanelAddProduct.Controls.Add(this.LabelOrderCost);
            this.PanelAddProduct.Controls.Add(this.ButtonAddProduct);
            this.PanelAddProduct.Location = new System.Drawing.Point(2, 2);
            this.PanelAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAddProduct.Name = "PanelAddProduct";
            this.PanelAddProduct.Size = new System.Drawing.Size(578, 38);
            this.PanelAddProduct.TabIndex = 1;
            // 
            // LabelCurrentOrderCost
            // 
            this.LabelCurrentOrderCost.AutoSize = true;
            this.LabelCurrentOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentOrderCost.Location = new System.Drawing.Point(472, 9);
            this.LabelCurrentOrderCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCurrentOrderCost.Name = "LabelCurrentOrderCost";
            this.LabelCurrentOrderCost.Size = new System.Drawing.Size(48, 18);
            this.LabelCurrentOrderCost.TabIndex = 3;
            this.LabelCurrentOrderCost.Text = "0 руб.";
            // 
            // LabelOrderCost
            // 
            this.LabelOrderCost.AutoSize = true;
            this.LabelOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderCost.Location = new System.Drawing.Point(333, 9);
            this.LabelOrderCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOrderCost.Name = "LabelOrderCost";
            this.LabelOrderCost.Size = new System.Drawing.Size(142, 18);
            this.LabelOrderCost.TabIndex = 2;
            this.LabelOrderCost.Text = "Стоимость заказа:";
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(2, 2);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(166, 33);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить товар";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.OnButtonAddProductClick);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.PanelAddProduct);
            this.PanelGeneral.Controls.Add(this.GroupBoxListProducts);
            this.PanelGeneral.Controls.Add(this.PanelControlButtons);
            this.PanelGeneral.Location = new System.Drawing.Point(8, 11);
            this.PanelGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(582, 415);
            this.PanelGeneral.TabIndex = 3;
            // 
            // GroupBoxListProducts
            // 
            this.GroupBoxListProducts.Controls.Add(this.PanelListProducts);
            this.GroupBoxListProducts.Location = new System.Drawing.Point(2, 44);
            this.GroupBoxListProducts.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxListProducts.Name = "GroupBoxListProducts";
            this.GroupBoxListProducts.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxListProducts.Size = new System.Drawing.Size(580, 318);
            this.GroupBoxListProducts.TabIndex = 3;
            this.GroupBoxListProducts.TabStop = false;
            this.GroupBoxListProducts.Text = "Товары в корзине";
            // 
            // PanelListProducts
            // 
            this.PanelListProducts.AutoScroll = true;
            this.PanelListProducts.Location = new System.Drawing.Point(-2, 17);
            this.PanelListProducts.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListProducts.Name = "PanelListProducts";
            this.PanelListProducts.Size = new System.Drawing.Size(580, 299);
            this.PanelListProducts.TabIndex = 0;
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.ButtonRemoveProducts);
            this.PanelControlButtons.Controls.Add(this.ButtonConfirmOrder);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 366);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(578, 41);
            this.PanelControlButtons.TabIndex = 2;
            // 
            // ButtonConfirmOrder
            // 
            this.ButtonConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConfirmOrder.Location = new System.Drawing.Point(446, 6);
            this.ButtonConfirmOrder.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonConfirmOrder.Name = "ButtonConfirmOrder";
            this.ButtonConfirmOrder.Size = new System.Drawing.Size(130, 33);
            this.ButtonConfirmOrder.TabIndex = 1;
            this.ButtonConfirmOrder.Text = "Оформить заказ";
            this.ButtonConfirmOrder.UseVisualStyleBackColor = true;
            this.ButtonConfirmOrder.Click += new System.EventHandler(this.OnButtonConfirmOrderClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(2, 6);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(70, 33);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // ButtonRemoveProducts
            // 
            this.ButtonRemoveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveProducts.Location = new System.Drawing.Point(197, 6);
            this.ButtonRemoveProducts.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRemoveProducts.Name = "ButtonRemoveProducts";
            this.ButtonRemoveProducts.Size = new System.Drawing.Size(152, 33);
            this.ButtonRemoveProducts.TabIndex = 2;
            this.ButtonRemoveProducts.Text = "Удалить продукты";
            this.ButtonRemoveProducts.UseVisualStyleBackColor = true;
            this.ButtonRemoveProducts.Click += new EventHandler(OnButtonDeleteProductsClick);
            // 
            // ClientManagerAddOrderSecondStepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 437);
            this.Controls.Add(this.PanelGeneral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(618, 476);
            this.MinimumSize = new System.Drawing.Size(618, 476);
            this.Name = "ClientManagerAddOrderSecondStepView";
            this.Text = "Корзина товаров";
            this.PanelAddProduct.ResumeLayout(false);
            this.PanelAddProduct.PerformLayout();
            this.PanelGeneral.ResumeLayout(false);
            this.GroupBoxListProducts.ResumeLayout(false);
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelAddProduct;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.FlowLayoutPanel PanelGeneral;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Button ButtonConfirmOrder;
        private System.Windows.Forms.GroupBox GroupBoxListProducts;
        private System.Windows.Forms.FlowLayoutPanel PanelListProducts;
        private System.Windows.Forms.Label LabelCurrentOrderCost;
        private System.Windows.Forms.Label LabelOrderCost;
        private System.Windows.Forms.Button ButtonRemoveProducts;
    }
}
