using System;
using System.Windows.Forms;

namespace View
{
    partial class SignInView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.BookerButton = new System.Windows.Forms.Button();
            this.StorekeeperButton = new System.Windows.Forms.Button();
            this.PurcрManagerButton = new System.Windows.Forms.Button();
            this.ClientManagerButton = new System.Windows.Forms.Button();
            this.CourierButton = new System.Windows.Forms.Button();
            this.FlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowLayout
            // 
            this.FlowLayout.Controls.Add(this.BookerButton);
            this.FlowLayout.Controls.Add(this.StorekeeperButton);
            this.FlowLayout.Controls.Add(this.PurcрManagerButton);
            this.FlowLayout.Controls.Add(this.ClientManagerButton);
            this.FlowLayout.Controls.Add(this.CourierButton);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(219, 623);
            this.FlowLayout.TabIndex = 0;
            // 
            // BookerButton
            // 
            this.BookerButton.AutoSize = true;
            this.BookerButton.Location = new System.Drawing.Point(3, 3);
            this.BookerButton.Name = "BookerButton";
            this.BookerButton.Size = new System.Drawing.Size(210, 115);
            this.BookerButton.TabIndex = 0;
            this.BookerButton.Text = "Бухгалтер";
            this.BookerButton.UseVisualStyleBackColor = true;
            this.BookerButton.Click+=new EventHandler(OnButtonBookerClick);
            // 
            // StorekeeperButton
            // 
            this.StorekeeperButton.AutoSize = true;
            this.StorekeeperButton.Location = new System.Drawing.Point(3, 124);
            this.StorekeeperButton.Name = "StorekeeperButton";
            this.StorekeeperButton.Size = new System.Drawing.Size(210, 115);
            this.StorekeeperButton.TabIndex = 1;
            this.StorekeeperButton.Text = "Кладовщик";
            this.StorekeeperButton.UseVisualStyleBackColor = true;
            this.StorekeeperButton.Click+=new EventHandler(OnButtonStorekeeperClick);
            // 
            // PurcрManagerButton
            // 
            this.PurcрManagerButton.AutoSize = true;
            this.PurcрManagerButton.Location = new System.Drawing.Point(3, 245);
            this.PurcрManagerButton.Name = "PurcрManagerButton";
            this.PurcрManagerButton.Size = new System.Drawing.Size(210, 115);
            this.PurcрManagerButton.TabIndex = 2;
            this.PurcрManagerButton.Text = "Менеджер по закупкам";
            this.PurcрManagerButton.UseVisualStyleBackColor = true;
            this.PurcрManagerButton.Click+=new EventHandler(OnButtonPurcpManagerClick);
            // 
            // ClientManagerButton
            // 
            this.ClientManagerButton.AutoSize = true;
            this.ClientManagerButton.Location = new System.Drawing.Point(3, 366);
            this.ClientManagerButton.Name = "ClientManagerButton";
            this.ClientManagerButton.Size = new System.Drawing.Size(210, 115);
            this.ClientManagerButton.TabIndex = 3;
            this.ClientManagerButton.Text = "Менеджер по клиентам";
            this.ClientManagerButton.UseVisualStyleBackColor = true;
            this.ClientManagerButton.Click += new EventHandler(OnButtonClientManagerClick);
            // 
            // CourierButton
            // 
            this.CourierButton.Location = new System.Drawing.Point(3, 487);
            this.CourierButton.Name = "CourierButton";
            this.CourierButton.Size = new System.Drawing.Size(210, 115);
            this.CourierButton.TabIndex = 4;
            this.CourierButton.Text = "Курьер";
            this.CourierButton.UseVisualStyleBackColor = true;
            this.CourierButton.Click+=new EventHandler(OnButtonCourierClick);
            // 
            // SignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 623);
            this.Controls.Add(this.FlowLayout);
            this.MaximumSize = new System.Drawing.Size(235, 662);
            this.MinimumSize = new System.Drawing.Size(235, 662);
            this.Name = "SignInView";
            this.Text = "Окно авторизации";
            this.FlowLayout.ResumeLayout(false);
            this.FlowLayout.PerformLayout();
            this.ResumeLayout(false);
        }

        private void PurcрManagerButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Button CourierButton;
        private System.Windows.Forms.Button ClientManagerButton;
        private System.Windows.Forms.Button PurcрManagerButton;
        private System.Windows.Forms.Button StorekeeperButton;
        private System.Windows.Forms.Button BookerButton;
    }
}

