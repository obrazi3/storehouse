using System;
using System.ComponentModel;

namespace View
{
    partial class ClientManagerProductCatalogView
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
            this.PanelMainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxCatalog = new System.Windows.Forms.GroupBox();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.ButtonAddProducts = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.GroupBoxCatalog);
            this.PanelMainContainer.Controls.Add(this.PanelForButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(5, 4);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(866, 751);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // GroupBoxCatalog
            // 
            this.GroupBoxCatalog.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxCatalog.Name = "GroupBoxCatalog";
            this.GroupBoxCatalog.Size = new System.Drawing.Size(863, 657);
            this.GroupBoxCatalog.TabIndex = 0;
            this.GroupBoxCatalog.TabStop = false;
            this.GroupBoxCatalog.Text = "Каталог";
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonAddProducts);
            this.PanelForButtons.Location = new System.Drawing.Point(3, 666);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(863, 84);
            this.PanelForButtons.TabIndex = 1;
            // 
            // ButtonAddProducts
            // 
            this.ButtonAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProducts.Location = new System.Drawing.Point(525, 46);
            this.ButtonAddProducts.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProducts.Name = "ButtonAddProducts";
            this.ButtonAddProducts.Size = new System.Drawing.Size(322, 31);
            this.ButtonAddProducts.TabIndex = 3;
            this.ButtonAddProducts.Text = "Завершить добавление товаров\r\n";
            this.ButtonAddProducts.UseVisualStyleBackColor = true;
            this.ButtonAddProducts.Click += new System.EventHandler(this.OnButtonAddProductsClick);
            // 
            // ClientManagerProductCatalogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 756);
            this.Controls.Add(this.PanelMainContainer);
            this.MaximumSize = new System.Drawing.Size(893, 803);
            this.MinimumSize = new System.Drawing.Size(893, 803);
            this.Name = "ClientManagerProductCatalogView";
            this.Text = "Каталог продукции";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.GroupBox GroupBoxCatalog;
        private System.Windows.Forms.Panel PanelForButtons;
        private System.Windows.Forms.Button ButtonAddProducts;
    }
}

