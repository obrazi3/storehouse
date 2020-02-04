using System;
using System.ComponentModel;

namespace View
{
    partial class PurcpManagerAddOrderSecondStepView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelMainContainer = new System.Windows.Forms.Panel();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.LabelNumberOfProductInDelivery = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.LabelMessageNotEnoughProducts = new System.Windows.Forms.Label();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelMainContainer.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PanelMainContainer);
            this.flowLayoutPanel1.Controls.Add(this.PanelControlButtons);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(926, 194);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.PanelMainContainer.Controls.Add(this.ButtonAddProduct);
            this.PanelMainContainer.Controls.Add(this.LabelNumberOfProductInDelivery);
            this.PanelMainContainer.Location = new System.Drawing.Point(3, 3);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(919, 76);
            this.PanelMainContainer.TabIndex = 8;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(748, 18);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(149, 29);
            this.ButtonAddProduct.TabIndex = 4;
            this.ButtonAddProduct.Text = "Добавить продукт";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click+=new EventHandler(OnButtonAddProductClick);
            // 
            // LabelNumberOfProductInDelivery
            // 
            this.LabelNumberOfProductInDelivery.AutoSize = true;
            this.LabelNumberOfProductInDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfProductInDelivery.Location = new System.Drawing.Point(6, 23);
            this.LabelNumberOfProductInDelivery.Name = "LabelNumberOfProductInDelivery";
            this.LabelNumberOfProductInDelivery.Size = new System.Drawing.Size(293, 18);
            this.LabelNumberOfProductInDelivery.TabIndex = 3;
            this.LabelNumberOfProductInDelivery.Text = "Количество позиций товара в поставке: ";
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.LabelMessageNotEnoughProducts);
            this.PanelControlButtons.Controls.Add(this.ButtonAddOrder);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 84);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(920, 106);
            this.PanelControlButtons.TabIndex = 7;
            // 
            // LabelMessageNotEnoughProducts
            // 
            this.LabelMessageNotEnoughProducts.AutoSize = true;
            this.LabelMessageNotEnoughProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageNotEnoughProducts.Location = new System.Drawing.Point(82, 17);
            this.LabelMessageNotEnoughProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMessageNotEnoughProducts.Name = "LabelMessageNotEnoughProducts";
            this.LabelMessageNotEnoughProducts.Size = new System.Drawing.Size(738, 18);
            this.LabelMessageNotEnoughProducts.TabIndex = 2;
            this.LabelMessageNotEnoughProducts.Text =
                "В поставке отсутствуют товары. Пожалуйста, добавьте товар, а затем продолжите офо" + "мление заказа.";
            this.LabelMessageNotEnoughProducts.Visible = false;
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddOrder.Location = new System.Drawing.Point(654, 77);
            this.ButtonAddOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(243, 29);
            this.ButtonAddOrder.TabIndex = 1;
            this.ButtonAddOrder.Text = "Завершить оформление заказа";
            this.ButtonAddOrder.UseVisualStyleBackColor = true;
            this.ButtonAddOrder.Click+=new EventHandler(OnButtonConfirmOrderClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 76);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(115, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(OnButtonBackClick);
            // 
            // PurcpManagerAddOrderSecondStepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 203);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PurcpManagerAddOrderSecondStepView";
            this.Text = "PurcpManagerAddOrderSecondStepView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelMainContainer.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.PanelControlButtons.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonAddOrder;
        private System.Windows.Forms.Label LabelMessageNotEnoughProducts;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Panel PanelMainContainer;
        private System.Windows.Forms.Label LabelNumberOfProductInDelivery;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}

