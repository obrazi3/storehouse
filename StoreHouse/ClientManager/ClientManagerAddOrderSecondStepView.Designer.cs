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
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxListProducts = new System.Windows.Forms.GroupBox();
            this.PanelListProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelAddProduct.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.GroupBoxListProducts.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelAddProduct.Controls.Add(this.ButtonAddProduct);
            this.PanelAddProduct.Location = new System.Drawing.Point(2, 2);
            this.PanelAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelAddProduct.Name = "PanelAddProduct";
            this.PanelAddProduct.Size = new System.Drawing.Size(674, 44);
            this.PanelAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(2, 2);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(194, 38);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить товар";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.PanelGeneral.Controls.Add(this.PanelAddProduct);
            this.PanelGeneral.Controls.Add(this.GroupBoxListProducts);
            this.PanelGeneral.Controls.Add(this.PanelControlButtons);
            this.PanelGeneral.Location = new System.Drawing.Point(10, 12);
            this.PanelGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(679, 479);
            this.PanelGeneral.TabIndex = 3;
            this.GroupBoxListProducts.Controls.Add(this.PanelListProducts);
            this.GroupBoxListProducts.Location = new System.Drawing.Point(2, 50);
            this.GroupBoxListProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxListProducts.Name = "GroupBoxListProducts";
            this.GroupBoxListProducts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxListProducts.Size = new System.Drawing.Size(677, 367);
            this.GroupBoxListProducts.TabIndex = 3;
            this.GroupBoxListProducts.TabStop = false;
            this.GroupBoxListProducts.Text = "Товары в корзине";
            this.PanelListProducts.AutoScroll = true;
            this.PanelListProducts.Location = new System.Drawing.Point(-2, 20);
            this.PanelListProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelListProducts.Name = "PanelListProducts";
            this.PanelListProducts.Size = new System.Drawing.Size(677, 345);
            this.PanelListProducts.TabIndex = 0;
            this.PanelControlButtons.Controls.Add(this.ButtonCancel);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 421);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(674, 47);
            this.PanelControlButtons.TabIndex = 2;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(590, 7);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 38);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(2, 7);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(82, 38);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 505);
            this.Controls.Add(this.PanelGeneral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(718, 544);
            this.MinimumSize = new System.Drawing.Size(718, 544);
            this.Name = "ClientManagerAddOrderSecondStepView";
            this.Text = " ";
            this.PanelAddProduct.ResumeLayout(false);
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
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.GroupBox GroupBoxListProducts;
        private System.Windows.Forms.FlowLayoutPanel PanelListProducts;
    }
}
