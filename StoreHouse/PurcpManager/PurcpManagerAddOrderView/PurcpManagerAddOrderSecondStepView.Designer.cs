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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelNumberOfProductInDelivery = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.LabelMessageNotEnoughProducts = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.PanelControlButtons);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(926, 194);
            this.flowLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LabelNumberOfProductInDelivery);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 76);
            this.panel1.TabIndex = 8;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(748, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить продукт";
            this.button1.UseVisualStyleBackColor = true;
            this.LabelNumberOfProductInDelivery.AutoSize = true;
            this.LabelNumberOfProductInDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfProductInDelivery.Location = new System.Drawing.Point(6, 23);
            this.LabelNumberOfProductInDelivery.Name = "LabelNumberOfProductInDelivery";
            this.LabelNumberOfProductInDelivery.Size = new System.Drawing.Size(293, 18);
            this.LabelNumberOfProductInDelivery.TabIndex = 3;
            this.LabelNumberOfProductInDelivery.Text = "Количество позиций товара в поставке: ";
            this.PanelControlButtons.Controls.Add(this.LabelMessageNotEnoughProducts);
            this.PanelControlButtons.Controls.Add(this.ButtonAddProduct);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 84);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(920, 106);
            this.PanelControlButtons.TabIndex = 7;
            this.LabelMessageNotEnoughProducts.AutoSize = true;
            this.LabelMessageNotEnoughProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageNotEnoughProducts.Location = new System.Drawing.Point(82, 17);
            this.LabelMessageNotEnoughProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMessageNotEnoughProducts.Name = "LabelMessageNotEnoughProducts";
            this.LabelMessageNotEnoughProducts.Size = new System.Drawing.Size(738, 18);
            this.LabelMessageNotEnoughProducts.TabIndex = 2;
            this.LabelMessageNotEnoughProducts.Text =
                (("В поставке отсутствуют товары. Пожалуйста, добавьте товар, а затем продолжите офо" + "" + "") +
                 "мление заказа.");
            this.LabelMessageNotEnoughProducts.Visible = false;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(654, 77);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(243, 29);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Завершить оформление заказа";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 76);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(115, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 203);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PurcpManagerAddOrderSecondStepView";
            this.Text = "PurcpManagerAddOrderSecondStepView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.PanelControlButtons.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Label LabelMessageNotEnoughProducts;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelNumberOfProductInDelivery;
        private System.Windows.Forms.Button button1;
    }
}

