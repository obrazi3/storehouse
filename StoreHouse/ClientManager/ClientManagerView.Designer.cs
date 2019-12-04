﻿using System;

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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.LookOrderButton = new System.Windows.Forms.Button();
            this.ButtonExitClientManager = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.AddOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.LookOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.ButtonExitClientManager);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 397);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(4, 4);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(215, 123);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.OnButtonAddOrderClick);
            // 
            // LookOrderButton
            // 
            this.LookOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookOrderButton.Location = new System.Drawing.Point(4, 135);
            this.LookOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.LookOrderButton.Name = "LookOrderButton";
            this.LookOrderButton.Size = new System.Drawing.Size(215, 123);
            this.LookOrderButton.TabIndex = 1;
            this.LookOrderButton.Text = "Просмотреть заказы";
            this.LookOrderButton.UseVisualStyleBackColor = true;
            this.LookOrderButton.Click += new System.EventHandler(this.OnButtonLookOrderClick);
            // 
            // ButtonExitClientManager
            // 
            this.ButtonExitClientManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExitClientManager.Location = new System.Drawing.Point(4, 266);
            this.ButtonExitClientManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExitClientManager.Name = "ButtonExitClientManager";
            this.ButtonExitClientManager.Size = new System.Drawing.Size(215, 123);
            this.ButtonExitClientManager.TabIndex = 2;
            this.ButtonExitClientManager.Text = "Выйти из Менеджера по работе с клиентами";
            this.ButtonExitClientManager.UseVisualStyleBackColor = true;
            this.ButtonExitClientManager.Click += new System.EventHandler(this.OnButtonExitClick);
            // 
            // ClientManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 411);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(260, 450);
            this.MinimumSize = new System.Drawing.Size(260, 450);
            this.Name = "ClientManagerView";
            this.Text = "Менеджер по работе с клиентами";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button LookOrderButton;
        private System.Windows.Forms.Button ButtonExitClientManager;
    }
}
