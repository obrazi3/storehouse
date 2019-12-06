using System;

namespace View
{
    partial class ClientManagerView
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
            this.PanelMainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.LookOrderButton = new System.Windows.Forms.Button();
            this.ButtonExitClientManager = new System.Windows.Forms.Button();
            this.ButtonShowOrders = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.AutoScroll = true;
            this.PanelMainContainer.Controls.Add(this.AddOrderButton);
            this.PanelMainContainer.Controls.Add(this.LookOrderButton);
            this.PanelMainContainer.Controls.Add(this.ButtonExitClientManager);
            this.PanelMainContainer.Controls.Add(this.ButtonShowOrders);
            this.PanelMainContainer.Location = new System.Drawing.Point(12, 14);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(596, 404);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(5, 6);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(287, 189);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.OnButtonAddOrderClick);
            // 
            // LookOrderButton
            // 
            this.LookOrderButton.Location = new System.Drawing.Point(302, 6);
            this.LookOrderButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LookOrderButton.Name = "LookOrderButton";
            this.LookOrderButton.Size = new System.Drawing.Size(287, 189);
            this.LookOrderButton.TabIndex = 1;
            this.LookOrderButton.Text = "Просмотреть заказ";
            this.LookOrderButton.UseVisualStyleBackColor = true;
            this.LookOrderButton.Click += new System.EventHandler(this.OnButtonLookOrderClick);
            // 
            // ButtonExitClientManager
            // 
            this.ButtonExitClientManager.Location = new System.Drawing.Point(5, 207);
            this.ButtonExitClientManager.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonExitClientManager.Name = "ButtonExitClientManager";
            this.ButtonExitClientManager.Size = new System.Drawing.Size(287, 189);
            this.ButtonExitClientManager.TabIndex = 2;
            this.ButtonExitClientManager.Text = "Выйти из Менеджера по работе с клиентами";
            this.ButtonExitClientManager.UseVisualStyleBackColor = true;
            this.ButtonExitClientManager.Click += new System.EventHandler(this.OnButtonExitClick);
            // 
            // ButtonShowOrders
            // 
            this.ButtonShowOrders.Location = new System.Drawing.Point(302, 207);
            this.ButtonShowOrders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonShowOrders.Name = "ButtonShowOrders";
            this.ButtonShowOrders.Size = new System.Drawing.Size(287, 189);
            this.ButtonShowOrders.TabIndex = 3;
            this.ButtonShowOrders.Text = "Отобразить список всех заказов";
            this.ButtonShowOrders.UseVisualStyleBackColor = true;
            this.ButtonShowOrders.Click += new System.EventHandler(this.OnButtonShowOrderClick);
            // 
            // ClientManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 425);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(642, 472);
            this.MinimumSize = new System.Drawing.Size(642, 472);
            this.Name = "ClientManagerView";
            this.Text = "Менеджер по работе с клиентами";
            this.PanelMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button LookOrderButton;
        private System.Windows.Forms.Button ButtonExitClientManager;
        private System.Windows.Forms.Button ButtonShowOrders;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
    }
}
