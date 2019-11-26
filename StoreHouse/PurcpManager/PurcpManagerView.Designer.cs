namespace View
{
    partial class PurcpManagerView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ViewInfoOrderProdButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.ViewInfoProviderButton = new System.Windows.Forms.Button();
            this.AddProviderButton = new System.Windows.Forms.Button();
            this.ViewInfoEndedProdButton = new System.Windows.Forms.Button();
            this.RemoveProviderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ViewInfoOrderProdButton);
            this.flowLayoutPanel1.Controls.Add(this.AddOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewInfoProviderButton);
            this.flowLayoutPanel1.Controls.Add(this.AddProviderButton);
            this.flowLayoutPanel1.Controls.Add(this.ViewInfoEndedProdButton);
            this.flowLayoutPanel1.Controls.Add(this.RemoveProviderButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 396);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ViewInfoOrderProdButton
            // 
            this.ViewInfoOrderProdButton.Location = new System.Drawing.Point(11, 13);
            this.ViewInfoOrderProdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewInfoOrderProdButton.Name = "ViewInfoOrderProdButton";
            this.ViewInfoOrderProdButton.Size = new System.Drawing.Size(211, 112);
            this.ViewInfoOrderProdButton.TabIndex = 0;
            this.ViewInfoOrderProdButton.Text = "Просмотреть информацию о сделаных заказах";
            this.ViewInfoOrderProdButton.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(11, 133);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(211, 112);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            // 
            // ViewInfoProviderButton
            // 
            this.ViewInfoProviderButton.Location = new System.Drawing.Point(11, 253);
            this.ViewInfoProviderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewInfoProviderButton.Name = "ViewInfoProviderButton";
            this.ViewInfoProviderButton.Size = new System.Drawing.Size(211, 112);
            this.ViewInfoProviderButton.TabIndex = 2;
            this.ViewInfoProviderButton.Text = "Просмотреть инфомацию о поставщике\r\n";
            this.ViewInfoProviderButton.UseVisualStyleBackColor = true;
            // 
            // AddProviderButton
            // 
            this.AddProviderButton.Location = new System.Drawing.Point(228, 13);
            this.AddProviderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddProviderButton.Name = "AddProviderButton";
            this.AddProviderButton.Size = new System.Drawing.Size(211, 112);
            this.AddProviderButton.TabIndex = 5;
            this.AddProviderButton.Text = "Добавить поставщика";
            this.AddProviderButton.UseVisualStyleBackColor = true;
            // 
            // ViewInfoEndedProdButton
            // 
            this.ViewInfoEndedProdButton.Location = new System.Drawing.Point(228, 133);
            this.ViewInfoEndedProdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewInfoEndedProdButton.Name = "ViewInfoEndedProdButton";
            this.ViewInfoEndedProdButton.Size = new System.Drawing.Size(211, 112);
            this.ViewInfoEndedProdButton.TabIndex = 4;
            this.ViewInfoEndedProdButton.Text = "Просмотреть информацию о закончившемся и заканчивающемся товаре";
            this.ViewInfoEndedProdButton.UseVisualStyleBackColor = true;
            // 
            // RemoveProviderButton
            // 
            this.RemoveProviderButton.Location = new System.Drawing.Point(228, 253);
            this.RemoveProviderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveProviderButton.Name = "RemoveProviderButton";
            this.RemoveProviderButton.Size = new System.Drawing.Size(211, 112);
            this.RemoveProviderButton.TabIndex = 3;
            this.RemoveProviderButton.Text = "Удалить поставщика";
            this.RemoveProviderButton.UseVisualStyleBackColor = true;
            // 
            // PurcpManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 370);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(471, 417);
            this.MinimumSize = new System.Drawing.Size(471, 417);
            this.Name = "PurcpManagerView";
            this.Text = "Менеждер по закупкам";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ViewInfoOrderProdButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button ViewInfoProviderButton;
        private System.Windows.Forms.Button RemoveProviderButton;
        private System.Windows.Forms.Button ViewInfoEndedProdButton;
        private System.Windows.Forms.Button AddProviderButton;
    }
}