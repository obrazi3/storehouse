using System;

namespace View
{
    partial class StorekeeperView
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
            this.SearchProviderOrderButton = new System.Windows.Forms.Button();
            this.SearchClientOrderButton = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SearchProviderOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.SearchClientOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.ButtonBack);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 523);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SearchProviderOrderButton
            // 
            this.SearchProviderOrderButton.Location = new System.Drawing.Point(8, 10);
            this.SearchProviderOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchProviderOrderButton.Name = "SearchProviderOrderButton";
            this.SearchProviderOrderButton.Size = new System.Drawing.Size(260, 161);
            this.SearchProviderOrderButton.TabIndex = 0;
            this.SearchProviderOrderButton.Text = "Поиск поставки от поставщика";
            this.SearchProviderOrderButton.UseVisualStyleBackColor = true;
            this.SearchProviderOrderButton.Click += new System.EventHandler(this.OnButtonSearchProviderOrderClick);
            // 
            // SearchClientOrderButton
            // 
            this.SearchClientOrderButton.Location = new System.Drawing.Point(8, 181);
            this.SearchClientOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchClientOrderButton.Name = "SearchClientOrderButton";
            this.SearchClientOrderButton.Size = new System.Drawing.Size(260, 161);
            this.SearchClientOrderButton.TabIndex = 1;
            this.SearchClientOrderButton.Text = "Поиск клиентского заказа";
            this.SearchClientOrderButton.UseVisualStyleBackColor = true;
            this.SearchClientOrderButton.Click += new System.EventHandler(this.OnButtonSearchClientOrderClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(8, 352);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(260, 161);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Выйти из кладовщика";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // StorekeeperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 523);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(293, 570);
            this.MinimumSize = new System.Drawing.Size(293, 570);
            this.Name = "StorekeeperView";
            this.Text = "StorekeeperView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SearchProviderOrderButton;
        private System.Windows.Forms.Button SearchClientOrderButton;
        private System.Windows.Forms.Button ButtonBack;
    }
}
