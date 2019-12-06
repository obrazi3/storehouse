using System.ComponentModel;

namespace View
{
    partial class ClientManagerShowListOrdersView
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
            this.PanelForOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelForOrders);
            this.PanelMainContainer.Controls.Add(this.PanelForButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(2, 12);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(794, 729);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelForOrders
            // 
            this.PanelForOrders.AutoScroll = true;
            this.PanelForOrders.Location = new System.Drawing.Point(3, 2);
            this.PanelForOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelForOrders.Name = "PanelForOrders";
            this.PanelForOrders.Size = new System.Drawing.Size(787, 652);
            this.PanelForOrders.TabIndex = 0;
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonBack);
            this.PanelForButtons.Location = new System.Drawing.Point(3, 658);
            this.PanelForButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(782, 69);
            this.PanelForButtons.TabIndex = 1;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(4, 16);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(132, 39);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // ClientManagerShowListOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(818, 799);
            this.MinimumSize = new System.Drawing.Size(818, 799);
            this.Name = "ClientManagerShowListOrdersView";
            this.Text = "Список клиентских заказов";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.FlowLayoutPanel PanelForOrders;
        private System.Windows.Forms.Panel PanelForButtons;
        private System.Windows.Forms.Button ButtonBack;
        
    }
}

