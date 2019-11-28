using System.ComponentModel;

namespace View
{
    partial class BookerShowNotPaidProviderOrdersView
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
            this.PanelNotPaidOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelNotPaidOrders.SuspendLayout();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelNotPaidOrders);
            this.PanelMainContainer.Controls.Add(this.PanelForButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(3, 3);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(926, 597);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelNotPaidOrders
            // 
            this.PanelNotPaidOrders.AutoScroll = true;
            this.PanelNotPaidOrders.Location = new System.Drawing.Point(3, 3);
            this.PanelNotPaidOrders.Name = "PanelNotPaidOrders";
            this.PanelNotPaidOrders.Size = new System.Drawing.Size(922, 512);
            this.PanelNotPaidOrders.TabIndex = 0;
           
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonBack);
            this.PanelForButtons.Location = new System.Drawing.Point(0, 520);
            this.PanelForButtons.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(926, 70);
            this.PanelForButtons.TabIndex = 1;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ButtonBack.Location = new System.Drawing.Point(10, 25);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 42);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // BookerShowNotPaidProviderOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 601);
            this.Controls.Add(this.PanelMainContainer);
            this.Name = "BookerShowNotPaidProviderOrdersView";
            this.Text = "Список неоплаченных поставок";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelNotPaidOrders.ResumeLayout(false);
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

       
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.FlowLayoutPanel PanelNotPaidOrders;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelForButtons;
    }
}

