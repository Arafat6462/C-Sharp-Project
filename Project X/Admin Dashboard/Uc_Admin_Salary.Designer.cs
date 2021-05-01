
namespace Project_X
{
    partial class Uc_Admin_Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Admin_Salary));
            this.guna2Elipse_Salary = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Pay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_SelectAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_PayAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Total_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse_Salary
            // 
            this.guna2Elipse_Salary.BorderRadius = 0;
            this.guna2Elipse_Salary.TargetControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(40, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Creat_lable_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(415, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Creat_lable_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(790, 44);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Salary";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Creat_lable_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(1165, 44);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "Status";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Creat_lable_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Animated = true;
            this.btn_Pay.BorderColor = System.Drawing.Color.White;
            this.btn_Pay.BorderRadius = 15;
            this.btn_Pay.BorderThickness = 1;
            this.btn_Pay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_Pay.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btn_Pay.CheckedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Pay.CheckedState.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_Pay.CheckedState.Parent = this.btn_Pay;
            this.btn_Pay.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Pay.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_Pay.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Pay.CustomImages.Parent = this.btn_Pay;
            this.btn_Pay.FillColor = System.Drawing.Color.Empty;
            this.btn_Pay.FillColor2 = System.Drawing.Color.Empty;
            this.btn_Pay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.Color.White;
            this.btn_Pay.HoverState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Pay.HoverState.Parent = this.btn_Pay;
            this.btn_Pay.Location = new System.Drawing.Point(955, 341);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.ShadowDecoration.Parent = this.btn_Pay;
            this.btn_Pay.Size = new System.Drawing.Size(150, 40);
            this.btn_Pay.TabIndex = 5;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.Visible = false;
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Animated = true;
            this.btn_SelectAll.BorderColor = System.Drawing.Color.White;
            this.btn_SelectAll.BorderRadius = 15;
            this.btn_SelectAll.BorderThickness = 1;
            this.btn_SelectAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_SelectAll.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btn_SelectAll.CheckedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_SelectAll.CheckedState.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_SelectAll.CheckedState.Parent = this.btn_SelectAll;
            this.btn_SelectAll.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectAll.CustomImages.CheckedImage")));
            this.btn_SelectAll.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_SelectAll.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_SelectAll.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_SelectAll.CustomImages.Parent = this.btn_SelectAll;
            this.btn_SelectAll.FillColor = System.Drawing.Color.Empty;
            this.btn_SelectAll.FillColor2 = System.Drawing.Color.Empty;
            this.btn_SelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectAll.ForeColor = System.Drawing.Color.White;
            this.btn_SelectAll.HoverState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_SelectAll.HoverState.Parent = this.btn_SelectAll;
            this.btn_SelectAll.Location = new System.Drawing.Point(978, 619);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.ShadowDecoration.Parent = this.btn_SelectAll;
            this.btn_SelectAll.Size = new System.Drawing.Size(180, 50);
            this.btn_SelectAll.TabIndex = 7;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_SelectAll.TextOffset = new System.Drawing.Point(40, 0);
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_PayAll
            // 
            this.btn_PayAll.Animated = true;
            this.btn_PayAll.BorderColor = System.Drawing.Color.White;
            this.btn_PayAll.BorderRadius = 15;
            this.btn_PayAll.BorderThickness = 1;
            this.btn_PayAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_PayAll.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btn_PayAll.CheckedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_PayAll.CheckedState.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_PayAll.CheckedState.Parent = this.btn_PayAll;
            this.btn_PayAll.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_PayAll.CustomImages.CheckedImage")));
            this.btn_PayAll.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_PayAll.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_PayAll.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_PayAll.CustomImages.Parent = this.btn_PayAll;
            this.btn_PayAll.FillColor = System.Drawing.Color.Empty;
            this.btn_PayAll.FillColor2 = System.Drawing.Color.Empty;
            this.btn_PayAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayAll.ForeColor = System.Drawing.Color.White;
            this.btn_PayAll.HoverState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_PayAll.HoverState.Parent = this.btn_PayAll;
            this.btn_PayAll.Location = new System.Drawing.Point(1208, 619);
            this.btn_PayAll.Name = "btn_PayAll";
            this.btn_PayAll.ShadowDecoration.Parent = this.btn_PayAll;
            this.btn_PayAll.Size = new System.Drawing.Size(168, 50);
            this.btn_PayAll.TabIndex = 7;
            this.btn_PayAll.Text = "Pay to All";
            this.btn_PayAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_PayAll.TextOffset = new System.Drawing.Point(40, 0);
            this.btn_PayAll.Click += new System.EventHandler(this.btn_PayAll_Click);
            // 
            // txt_Total_salary
            // 
            this.txt_Total_salary.BorderColor = System.Drawing.Color.Gray;
            this.txt_Total_salary.BorderRadius = 5;
            this.txt_Total_salary.BorderThickness = 2;
            this.txt_Total_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total_salary.DefaultText = "";
            this.txt_Total_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Total_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Total_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Total_salary.DisabledState.Parent = this.txt_Total_salary;
            this.txt_Total_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Total_salary.FillColor = System.Drawing.Color.DimGray;
            this.txt_Total_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Total_salary.FocusedState.Parent = this.txt_Total_salary;
            this.txt_Total_salary.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txt_Total_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.txt_Total_salary.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.txt_Total_salary.HoverState.Parent = this.txt_Total_salary;
            this.txt_Total_salary.Location = new System.Drawing.Point(40, 619);
            this.txt_Total_salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Total_salary.Name = "txt_Total_salary";
            this.txt_Total_salary.PasswordChar = '\0';
            this.txt_Total_salary.PlaceholderText = "Total Salary";
            this.txt_Total_salary.SelectedText = "";
            this.txt_Total_salary.ShadowDecoration.Parent = this.txt_Total_salary;
            this.txt_Total_salary.Size = new System.Drawing.Size(270, 50);
            this.txt_Total_salary.TabIndex = 8;
            this.txt_Total_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Total_salary.TextChanged += new System.EventHandler(this.txt_Total_salary_TextChanged);
            // 
            // Uc_Admin_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txt_Total_salary);
            this.Controls.Add(this.btn_PayAll);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Uc_Admin_Salary";
            this.Size = new System.Drawing.Size(2196, 1303);
            this.Load += new System.EventHandler(this.Uc_Admin_Salary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_Salary;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Pay;
        private Guna.UI2.WinForms.Guna2GradientButton btn_SelectAll;
        private Guna.UI2.WinForms.Guna2GradientButton btn_PayAll;
        private Guna.UI2.WinForms.Guna2TextBox txt_Total_salary;
    }
}
