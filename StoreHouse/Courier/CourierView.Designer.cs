using System;

namespace View
{
    partial class CourierView
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
            this.ButtonGetOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.PanelMainContainer.Controls.Add(this.ButtonGetOrder);
            this.PanelMainContainer.Controls.Add(this.ButtonBack);
            this.PanelMainContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(267, 472);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // GetInfoOrderButton
            // 
            this.ButtonGetOrder.Location = new System.Drawing.Point(9, 11);
            this.ButtonGetOrder.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.ButtonGetOrder.Name = "ButtonGetOrder";
            this.ButtonGetOrder.Size = new System.Drawing.Size(247, 218);
            this.ButtonGetOrder.TabIndex = 0;
            this.ButtonGetOrder.Text = "Получить заказ для доставки";
            this.ButtonGetOrder.UseVisualStyleBackColor = true;
            this.ButtonGetOrder.Click += new EventHandler(OnButtonGetOrderInfoClick);
            // 
            // button1
            // 
            this.ButtonBack.Location = new System.Drawing.Point(9, 245);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(247, 218);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Выйти из курьера";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new EventHandler(OnButtonExitCourierClick);
            // 
            // CourierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 472);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1000, 999);
            this.MinimumSize = new System.Drawing.Size(282, 287);
            this.Name = "CourierView";
            this.Text = "Курьер";
            this.PanelMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Button ButtonGetOrder;
        private System.Windows.Forms.Button ButtonBack;
    }
}
