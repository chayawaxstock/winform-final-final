namespace manageTask
{
    partial class ContactManager
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
            this.btn_send_message = new Telerik.WinControls.UI.RadButton();
            this.lbl_message = new Telerik.WinControls.UI.RadLabel();
            this.richTextBoxMessage = new Telerik.WinControls.UI.RadRichTextEditor();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBoxMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(558, 392);
            this.btn_send_message.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(100, 36);
            this.btn_send_message.TabIndex = 5;
            this.btn_send_message.Text = "Send";
            this.btn_send_message.ThemeName = "MaterialTeal";
            // 
            // lbl_message
            // 

            this.lbl_message.Location = new System.Drawing.Point(31, 104);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(166, 23);
            this.lbl_message.TabIndex = 4;
            this.lbl_message.Text = "Write your message";
            this.lbl_message.ThemeName = "MaterialTeal";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lbl_message.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);

            this.lbl_message.Location = new System.Drawing.Point(314, 57);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(136, 21);
            this.lbl_message.TabIndex = 4;
            this.lbl_message.Text = "Write your message";
            this.lbl_message.ThemeName = "MaterialTeal";

            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxMessage.LayoutMode = Telerik.WinForms.Documents.Model.DocumentLayoutMode.Flow;

            this.richTextBoxMessage.Location = new System.Drawing.Point(26, 147);

            this.richTextBoxMessage.Location = new System.Drawing.Point(126, 128);

            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.richTextBoxMessage.SelectionStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));

            this.richTextBoxMessage.Size = new System.Drawing.Size(413, 213);

            this.richTextBoxMessage.Size = new System.Drawing.Size(549, 224);

            this.richTextBoxMessage.TabIndex = 3;
            this.richTextBoxMessage.ThemeName = "MaterialTeal";
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(475, 452);

            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.btn_send_message);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.richTextBoxMessage);
            this.Name = "ContactManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ContactManager";
            this.ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)(this.btn_send_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBoxMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_send_message;
        private Telerik.WinControls.UI.RadLabel lbl_message;
        private Telerik.WinControls.UI.RadRichTextEditor richTextBoxMessage;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}