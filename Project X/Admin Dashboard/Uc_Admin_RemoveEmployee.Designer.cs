
namespace Project_X
{
    partial class Uc_Admin_RemoveEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Admin_RemoveEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse_RemoveEmployee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_searachID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridView__RemoveEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView__RemoveEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse_RemoveEmployee
            // 
            this.guna2Elipse_RemoveEmployee.BorderRadius = 0;
            // 
            // txt_searachID
            // 
            this.txt_searachID.BorderColor = System.Drawing.Color.Gray;
            this.txt_searachID.BorderRadius = 5;
            this.txt_searachID.BorderThickness = 2;
            this.txt_searachID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searachID.DefaultText = "";
            this.txt_searachID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searachID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searachID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searachID.DisabledState.Parent = this.txt_searachID;
            this.txt_searachID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searachID.FillColor = System.Drawing.Color.DimGray;
            this.txt_searachID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searachID.FocusedState.Parent = this.txt_searachID;
            this.txt_searachID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searachID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txt_searachID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.txt_searachID.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.txt_searachID.HoverState.Parent = this.txt_searachID;
            this.txt_searachID.Location = new System.Drawing.Point(17, 92);
            this.txt_searachID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searachID.Name = "txt_searachID";
            this.txt_searachID.PasswordChar = '\0';
            this.txt_searachID.PlaceholderText = "Enter Employee ID";
            this.txt_searachID.SelectedText = "";
            this.txt_searachID.ShadowDecoration.Parent = this.txt_searachID;
            this.txt_searachID.Size = new System.Drawing.Size(270, 50);
            this.txt_searachID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Id";
            // 
            // btn_DeleteEmployee
            // 
            this.btn_DeleteEmployee.Animated = true;
            this.btn_DeleteEmployee.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_DeleteEmployee.BorderRadius = 15;
            this.btn_DeleteEmployee.BorderThickness = 1;
            this.btn_DeleteEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_DeleteEmployee.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.btn_DeleteEmployee.CheckedState.FillColor = System.Drawing.Color.Crimson;
            this.btn_DeleteEmployee.CheckedState.FillColor2 = System.Drawing.Color.LightPink;
            this.btn_DeleteEmployee.CheckedState.Parent = this.btn_DeleteEmployee;
            this.btn_DeleteEmployee.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.CustomImages.CheckedImage")));
            this.btn_DeleteEmployee.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DeleteEmployee.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_DeleteEmployee.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_DeleteEmployee.CustomImages.Parent = this.btn_DeleteEmployee;
            this.btn_DeleteEmployee.FillColor = System.Drawing.Color.Empty;
            this.btn_DeleteEmployee.FillColor2 = System.Drawing.Color.Empty;
            this.btn_DeleteEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteEmployee.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_DeleteEmployee.HoverState.Parent = this.btn_DeleteEmployee;
            this.btn_DeleteEmployee.Location = new System.Drawing.Point(1183, 77);
            this.btn_DeleteEmployee.Name = "btn_DeleteEmployee";
            this.btn_DeleteEmployee.ShadowDecoration.Parent = this.btn_DeleteEmployee;
            this.btn_DeleteEmployee.Size = new System.Drawing.Size(240, 65);
            this.btn_DeleteEmployee.TabIndex = 5;
            this.btn_DeleteEmployee.Text = "Delete Employee";
            this.btn_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DeleteEmployee.TextOffset = new System.Drawing.Point(40, 0);
            this.btn_DeleteEmployee.Click += new System.EventHandler(this.btn_DeleteEmployee_Click);
            // 
            // DataGridView__RemoveEmployee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView__RemoveEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView__RemoveEmployee.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView__RemoveEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView__RemoveEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView__RemoveEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView__RemoveEmployee.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView__RemoveEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView__RemoveEmployee.EnableHeadersVisualStyles = false;
            this.DataGridView__RemoveEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView__RemoveEmployee.Location = new System.Drawing.Point(17, 201);
            this.DataGridView__RemoveEmployee.Name = "DataGridView__RemoveEmployee";
            this.DataGridView__RemoveEmployee.RowHeadersVisible = false;
            this.DataGridView__RemoveEmployee.RowHeadersWidth = 51;
            this.DataGridView__RemoveEmployee.RowTemplate.Height = 24;
            this.DataGridView__RemoveEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView__RemoveEmployee.Size = new System.Drawing.Size(1447, 630);
            this.DataGridView__RemoveEmployee.TabIndex = 6;
            this.DataGridView__RemoveEmployee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView__RemoveEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView__RemoveEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView__RemoveEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView__RemoveEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView__RemoveEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView__RemoveEmployee.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView__RemoveEmployee.ThemeStyle.ReadOnly = false;
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView__RemoveEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Uc_Admin_RemoveEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DataGridView__RemoveEmployee);
            this.Controls.Add(this.btn_DeleteEmployee);
            this.Controls.Add(this.txt_searachID);
            this.Controls.Add(this.label1);
            this.Name = "Uc_Admin_RemoveEmployee";
            this.Size = new System.Drawing.Size(1464, 834);
            this.Load += new System.EventHandler(this.Uc_Admin_RemoveEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView__RemoveEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_RemoveEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txt_searachID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_DeleteEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView__RemoveEmployee;
    }
}
