
namespace Project_X
{
    partial class Uc_settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Elipse_Settings = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(620, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 232);
            this.button1.TabIndex = 0;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // guna2Elipse_Settings
            // 
            this.guna2Elipse_Settings.BorderRadius = 0;
            this.guna2Elipse_Settings.TargetControl = this;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(0, 713);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "down left";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(1154, 732);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 55);
            this.button4.TabIndex = 6;
            this.button4.Text = "down right";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1102, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(273, 61);
            this.button5.TabIndex = 7;
            this.button5.Text = "top right";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Uc_settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(124)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Uc_settings";
            this.Size = new System.Drawing.Size(1375, 787);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_Settings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
