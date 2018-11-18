namespace manageTask
{
    partial class AffiliationWorksToTeamLeader
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
            this.lbl_n = new Telerik.WinControls.UI.RadLabel();
            this.lbl_team = new Telerik.WinControls.UI.RadLabel();
            this.btn_workerToTeamleader = new Telerik.WinControls.UI.RadButton();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.cmbx_worker = new Telerik.WinControls.UI.RadDropDownList();
            this.cmbx_team = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_workerToTeamleader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.Location = new System.Drawing.Point(82, 116);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(93, 21);
            this.lbl_n.TabIndex = 0;
            this.lbl_n.Text = "Worker name";
            this.lbl_n.ThemeName = "MaterialTeal";
            // 
            // lbl_team
            // 
            this.lbl_team.Location = new System.Drawing.Point(382, 116);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(84, 21);
            this.lbl_team.TabIndex = 1;
            this.lbl_team.Text = "Teamleader";
            this.lbl_team.ThemeName = "MaterialTeal";
            this.lbl_team.Visible = false;
            // 
            // btn_workerToTeamleader
            // 
            this.btn_workerToTeamleader.Location = new System.Drawing.Point(219, 228);
            this.btn_workerToTeamleader.Name = "btn_workerToTeamleader";
            this.btn_workerToTeamleader.Size = new System.Drawing.Size(250, 36);
            this.btn_workerToTeamleader.TabIndex = 4;
            this.btn_workerToTeamleader.Text = "Affiliation works to team leader";
            this.btn_workerToTeamleader.ThemeName = "MaterialTeal";
            this.btn_workerToTeamleader.Visible = false;
            this.btn_workerToTeamleader.Click += new System.EventHandler(this.btn_workerToTeamleader_Click);
            // 
            // cmbx_worker
            // 
            this.cmbx_worker.Location = new System.Drawing.Point(69, 143);
            this.cmbx_worker.Name = "cmbx_worker";
            this.cmbx_worker.Size = new System.Drawing.Size(202, 36);
            this.cmbx_worker.TabIndex = 7;
            this.cmbx_worker.Text = "radDropDownList1";
            this.cmbx_worker.ThemeName = "MaterialTeal";
            this.cmbx_worker.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbx_worker_SelectedIndexChanged);
            // 
            // cmbx_team
            // 
            this.cmbx_team.Location = new System.Drawing.Point(372, 143);
            this.cmbx_team.Name = "cmbx_team";
            this.cmbx_team.Size = new System.Drawing.Size(210, 36);
            this.cmbx_team.TabIndex = 8;
            this.cmbx_team.Text = "radDropDownList2";
            this.cmbx_team.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(153, 55);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(281, 21);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "choose worker to affiliation to teamLeader";
            this.radLabel1.ThemeName = "MaterialTeal";
            // 
            // AffiliationWorksToTeamLeader
            // 
            this.ClientSize = new System.Drawing.Size(834, 592);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cmbx_team);
            this.Controls.Add(this.cmbx_worker);
            this.Controls.Add(this.btn_workerToTeamleader);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_n);
            this.Name = "AffiliationWorksToTeamLeader";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.AffiliationWorksToTeamLeader_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_workerToTeamleader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList cmbx_workers;
        private Telerik.WinControls.UI.RadLabel lbl_name;
        private Telerik.WinControls.UI.RadLabel lbl_team_leader;
        private Telerik.WinControls.UI.RadDropDownList cmbx_teamLeaders;
        private Telerik.WinControls.UI.RadLabel lbl_n;
        private Telerik.WinControls.UI.RadLabel lbl_team;
        private Telerik.WinControls.UI.RadButton btn_workerToTeamleader;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadDropDownList cmbx_worker;
        private Telerik.WinControls.UI.RadDropDownList cmbx_team;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}