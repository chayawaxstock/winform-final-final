namespace manageTask
{
    partial class AddWorkerToProject
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
            this.lbl_worker = new Telerik.WinControls.UI.RadLabel();
            this.lbl_project = new Telerik.WinControls.UI.RadLabel();
            this.btn_addProjectToWorker = new Telerik.WinControls.UI.RadButton();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.btn_checkAll = new Telerik.WinControls.UI.RadButton();
            this.cmbx_projects = new Telerik.WinControls.UI.RadDropDownList();
            this.checkedListBoxWorkers = new Telerik.WinControls.UI.RadCheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_worker
            // 
            this.lbl_worker.Location = new System.Drawing.Point(339, 33);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(61, 21);
            this.lbl_worker.TabIndex = 1;
            this.lbl_worker.Text = "Workers";
            this.lbl_worker.ThemeName = "MaterialTeal";
            // 
            // lbl_project
            // 
            this.lbl_project.Location = new System.Drawing.Point(29, 24);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(53, 21);
            this.lbl_project.TabIndex = 3;
            this.lbl_project.Text = "Project";
            this.lbl_project.ThemeName = "MaterialTeal";
            // 
            // btn_addProjectToWorker
            // 
            this.btn_addProjectToWorker.Location = new System.Drawing.Point(536, 397);
            this.btn_addProjectToWorker.Name = "btn_addProjectToWorker";
            this.btn_addProjectToWorker.Size = new System.Drawing.Size(236, 36);
            this.btn_addProjectToWorker.TabIndex = 4;
            this.btn_addProjectToWorker.Text = "Add the project to the worker";
            this.btn_addProjectToWorker.ThemeName = "MaterialTeal";
            this.btn_addProjectToWorker.Visible = false;
            this.btn_addProjectToWorker.Click += new System.EventHandler(this.btn_addProjectToWorker_Click);
            // 
            // btn_checkAll
            // 
            this.btn_checkAll.Location = new System.Drawing.Point(339, 390);
            this.btn_checkAll.Name = "btn_checkAll";
            this.btn_checkAll.Size = new System.Drawing.Size(108, 36);
            this.btn_checkAll.TabIndex = 8;
            this.btn_checkAll.Text = "Check all";
            this.btn_checkAll.ThemeName = "MaterialTeal";
            this.btn_checkAll.Click += new System.EventHandler(this.btn_checkAll_Click);
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.Location = new System.Drawing.Point(107, 18);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(203, 36);
            this.cmbx_projects.TabIndex = 10;
            this.cmbx_projects.Text = "radDropDownList1";
            this.cmbx_projects.ThemeName = "MaterialTeal";
            this.cmbx_projects.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbx_projects_SelectedIndexChanged);
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.GroupItemSize = new System.Drawing.Size(200, 36);
            this.checkedListBoxWorkers.ItemSize = new System.Drawing.Size(200, 36);
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(339, 60);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(160, 315);
            this.checkedListBoxWorkers.TabIndex = 11;
            this.checkedListBoxWorkers.ThemeName = "MaterialTeal";
            this.checkedListBoxWorkers.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.checkedListBoxWorkers_ItemCheckedChanged);
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 477);
            this.Controls.Add(this.checkedListBoxWorkers);
            this.Controls.Add(this.cmbx_projects);
            this.Controls.Add(this.btn_checkAll);
            this.Controls.Add(this.btn_addProjectToWorker);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.lbl_worker);
            this.Name = "AddWorkerToProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Add a worker to a project";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.AddWorkerToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbx_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lbl_worker;
        private Telerik.WinControls.UI.RadLabel lbl_project;
        private Telerik.WinControls.UI.RadButton btn_addProjectToWorker;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadButton btn_checkAll;
        private Telerik.WinControls.UI.RadDropDownList cmbx_projects;
        private Telerik.WinControls.UI.RadCheckedListBox checkedListBoxWorkers;
    }
}