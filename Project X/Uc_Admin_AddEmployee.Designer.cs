
namespace Project_X
{
    partial class Uc_Admin_AddEmployee
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
            this.guna2Elipse_AddEmployee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2Elipse_AddEmployee
            // 
            this.guna2Elipse_AddEmployee.BorderRadius = 0;
            this.guna2Elipse_AddEmployee.TargetControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Uc_Admin_AddEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button1);
            this.Name = "Uc_Admin_AddEmployee";
            this.Size = new System.Drawing.Size(1464, 834);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_AddEmployee;
        private System.Windows.Forms.Button button1;
    }
}
