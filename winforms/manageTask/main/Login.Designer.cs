namespace manageTask
{
    partial class Login
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
            this.lbl_name = new Telerik.WinControls.UI.RadLabel();
            this.lbl_password = new Telerik.WinControls.UI.RadLabel();
            this.txt_userName = new Telerik.WinControls.UI.RadTextBox();
            this.txt_password = new Telerik.WinControls.UI.RadTextBox();
            this.btn_signIn = new Telerik.WinControls.UI.RadButton();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(95, 57);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "user name:";
            this.lbl_name.ThemeName = "MaterialTeal";
            // 
            // lbl_password
            // 
            this.lbl_password.Location = new System.Drawing.Point(95, 91);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(74, 21);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "password:";
            this.lbl_password.ThemeName = "MaterialTeal";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(174, 57);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 36);
            this.txt_userName.TabIndex = 2;
            this.txt_userName.ThemeName = "MaterialTeal";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(174, 91);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 36);
            this.txt_password.TabIndex = 3;
            this.txt_password.ThemeName = "MaterialTeal";
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(145, 135);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(163, 38);
            this.btn_signIn.TabIndex = 4;
            this.btn_signIn.Text = "sign-in";
            this.btn_signIn.ThemeName = "MaterialTeal";
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 547);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sign-in";
            this.ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.UI.RadLabel lbl_password;
        private Telerik.WinControls.UI.RadTextBox txt_userName;
        private Telerik.WinControls.UI.RadTextBox txt_password;
        private Telerik.WinControls.UI.RadButton btn_signIn;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}

