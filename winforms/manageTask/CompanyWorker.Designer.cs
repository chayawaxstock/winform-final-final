namespace manageTask
{
    partial class CompanyWorker
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.setTimeToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.graphHoursStatusToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.cotactTheManagerToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.yourTasksToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.lbl_date = new Telerik.WinControls.UI.RadLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.setTimeToolStripMenuItem,
            this.graphHoursStatusToolStripMenuItem,
            this.cotactTheManagerToolStripMenuItem,
            this.yourTasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1541, 37);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.ThemeName = "MaterialTeal";
            // 
            // setTimeToolStripMenuItem
            // 
            this.setTimeToolStripMenuItem.Name = "setTimeToolStripMenuItem";
            this.setTimeToolStripMenuItem.Text = "Set time";
            // 
            // graphHoursStatusToolStripMenuItem
            // 
            this.graphHoursStatusToolStripMenuItem.Name = "graphHoursStatusToolStripMenuItem";
            this.graphHoursStatusToolStripMenuItem.Text = "Graph hours status";
            // 
            // cotactTheManagerToolStripMenuItem
            // 
            this.cotactTheManagerToolStripMenuItem.Name = "cotactTheManagerToolStripMenuItem";
            this.cotactTheManagerToolStripMenuItem.Text = "Cotact the manager";
            // 
            // yourTasksToolStripMenuItem
            // 
            this.yourTasksToolStripMenuItem.Name = "yourTasksToolStripMenuItem";
            this.yourTasksToolStripMenuItem.Text = "Your tasks";
            // 
            // radClock1
            // 
            this.radClock1.BackColor = System.Drawing.Color.Transparent;
            this.radClock1.Location = new System.Drawing.Point(1242, 64);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(134, 135);
            this.radClock1.TabIndex = 4;
            this.radClock1.ThemeName = "MaterialTeal";
            // 
            // lbl_date
            // 
            this.lbl_date.Location = new System.Drawing.Point(1311, 225);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(2, 2);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.ThemeName = "MaterialTeal";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CompanyWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 877);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.radClock1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanyWorker";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CompanyWorker";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.CompanyWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem setTimeToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem graphHoursStatusToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem cotactTheManagerToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem yourTasksToolStripMenuItem;
        private Telerik.WinControls.UI.RadClock radClock1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel lbl_date;
        private System.Windows.Forms.Timer timer2;
    }
}