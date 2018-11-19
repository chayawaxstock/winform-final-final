using manageTask.HelpModel;
using manageTask.Logic;
using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace manageTask
{
    public partial class Report : Telerik.WinControls.UI.RadForm
    {
        public Report()
        {
            InitializeComponent();
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.EnableAlternatingRowColor = true;
             FillData();
           // BindingToHierarchicalGridProgramatically_Load();
        }

     

//private void BindingToHierarchicalGridProgramatically_Load()
//        {
//            DataTable dt = new DataTable();
           
          

//            radGridView1.DataSource = reportProjectBindingSource;

//            GridViewTemplate template = new GridViewTemplate();
//            template.DataSource = departmentUserBindingSource;
//            radGridView1.MasterTemplate.Templates.Add(template);

//            GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate);
//            relation.ChildTemplate = template;
//            relation.RelationName = "SuppliersProducts";
//            relation.ParentColumnNames.Add("SupplierID");
//            relation.ChildColumnNames.Add("SupplierID");
//            radGridView1.Relations.Add(relation);
//        }

        List<Project> data = new List<Project>();
        string type;
        string[] columdNames = new string[] { "ProjectName", "CustomerName", "DateBegin","DateEnd","IsFinish"
        ,"manager","numHourForProject","DaysStay","NumWorkers","sumHourWork","presentDoing","doingEveryDay"};
          private Type[] typeColums = new Type[] {typeof(string), typeof(string), typeof(DateTime), typeof(DateTime)
          ,typeof(bool),typeof(string),typeof(decimal),typeof(int),typeof(int),typeof(decimal),typeof(decimal),typeof(decimal)};

        private void radButtonPrint_Click(object sender, EventArgs e)
        {
            this.radGridView1.Print(true, this.radPrintDocument2);
        }

        private void radButtonPrintPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.Document = this.radPrintDocument2;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }

        private void radButtonPrintSettings_Click(object sender, EventArgs e)
        {
            GridViewPrintSettingsDialog dialog = new GridViewPrintSettingsDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.ShowPreviewButton = false;
            dialog.PrintDocument = this.radPrintDocument2;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radButtonPrintPreview_Click(sender, e);
            }
        }

        DataTable dt = new DataTable();
        public void FillData()
        {
            for (int i = 0; i < columdNames.Length; i++)
            {
                dt.Columns.Add(columdNames[i], typeColums[i]);
            }
           dt.Columns.Add("DepartmentUser");
        List<ReportProject> reportProjects = ReportRequests.CreateReportProjects();
            DataTable dt2 = new DataTable();
            foreach (var item in reportProjects)
            {
                dt2 = new DataTable();
                dt.Rows.Add(item.Project.ProjectName,item.Project.CustomerName,item.Project.DateBegin,
                    item.Project.DateEnd,item.Project.IsFinish,item.manager,item.Project.numHourForProject,
                    item.DaysStay,item.NumWorkers,item.sumHourWork,item.presentDoing,item.NumHourDoDaysWorker,
                    item.DepartmentUser);
            }

           

            this.radGridView1.DataSource = dt;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.DataView.BypassFilter = true;
            this.radGridView1.FilterChanged += radGridView1_FilterChanged;

            //master template
            GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();
            item1.Add(new GridViewSummaryItem("ProjectName", "Count: {0}", GridAggregateFunction.Count));
            this.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item1);

            radGridView1.MasterTemplate.ShowTotals = true;

            //child template
            //GridViewSummaryRowItem item3 = new GridViewSummaryRowItem();
            //GridViewSummaryRowItem item4 = new GridViewSummaryRowItem();

            //item3.Add(new GridViewSummaryItem("UnitPrice", "Avg: {0:c}", GridAggregateFunction.Avg));
            //item4.Add(new GridViewSummaryItem("Quantity", "Sum: {0}", GridAggregateFunction.Sum));

            //this.radGridView1.MasterTemplate.Templates[0].SummaryRowsTop.Add(item3);
            //this.radGridView1.MasterTemplate.Templates[0].SummaryRowsBottom.Add(item4);



            //radGridView1.Columns["Image"].ImageLayout = ImageLayout.Zoom;





            //GridViewTemplate childTemplate2 = new GridViewTemplate();
            //childTemplate2.DataSource = songsBindingSource;
            //childTemplate2.Caption = "Songs";
            //this.radGridView1.MasterTemplate.Templates.Add(childTemplate2);
            //GridViewRelation relation2 = new GridViewRelation(this.radGridView1.MasterTemplate);
            //relation2.RelationName = "productdescription_productModelDescription";
            //relation2.ParentColumnNames.Add("AlbumID");
            //relation2.ChildColumnNames.Add("AlbumID");
            //relation2.ChildTemplate = childTemplate2;
            //this.radGridView1.Relations.Add(relation2);

            // GridViewTemplate childTemplate1 = new GridViewTemplate();

            // dt2.Columns.Add("Department", typeof(string));


            //GridViewTemplate childTemplate1 = new GridViewTemplate();
            //childTemplate1.Columns.Add("DepartmentUser");
            //childTemplate1.DataSource = reportProjects[0].DepartmentUser;
            //childTemplate1.Caption = "department";
            //this.radGridView1.MasterTemplate.Templates.Add(childTemplate1);


            //GridViewRelation relation1 = new GridViewRelation(this.radGridView1.MasterTemplate);
            //relation1.RelationName = "productmodel_productModelDescription";
            //relation1.ParentColumnNames.Add("ProjectName");
            //relation1.ChildColumnNames.Add("Department");
            //relation1.ChildTemplate = childTemplate1;
            //this.radGridView1.Relations.Add(relation1);
            //  radGridView1.AutoGenerateHierarchy = true;

        }
        #region VirtualGrid events 

        private void radGridView1_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.ItemChanged)
            {
                dt.DefaultView.RowFilter = this.radGridView1.FilterDescriptors.Expression;
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                dt.DefaultView.RowFilter = "";
            }
        }

        #endregion
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // this.AddSummaries();
            // SetConditions();

            this.ListViewOption.SelectedIndex = 0;
            this.radComboBoxSummaries.SelectedIndex = 0;
            //  this.radGridView1.Columns[0].Width = 30;
        }


        private void radButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (saveFileDialog.FileName.Equals(String.Empty))
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show("Please enter a file name.");
                return;
            }

            string fileName = this.saveFileDialog.FileName;
            bool openExportFile = false;

            switch (this.ListViewOption.SelectedIndex)
            {
                case 0: //export to excelML
                    RunExportToExcelML(fileName, ref openExportFile);
                    break;

                case 1: //export to CSV
                    RunExportToCSV(fileName, ref openExportFile);
                    break;

                case 2: //export to HTML
                    RunExportToHTML(fileName, ref openExportFile);
                    break;

                case 3: //export to PDF
                    RunExportToPDF(fileName, ref openExportFile);
                    break;
            }

            if (openExportFile)
            {
                try
                {
                    Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    string message = String.Format("The file cannot be opened on your system.\nError message: {0}", ex.Message);
                    RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        //private void SetConditions()
        //{
        //    //add a couple of sample formatting objects
        //    ConditionalFormattingObject c1 = new ConditionalFormattingObject("Red", ConditionTypes.Equal, "London", "", true);
        //    c1.RowBackColor = Color.FromArgb(255, 153, 0);
        //    c1.RowForeColor = Color.Black;
        //    radGridView1.Columns["City"].ConditionalFormattingObjectList.Add(c1);

        //    ConditionalFormattingObject c2 = new ConditionalFormattingObject("Green", ConditionTypes.Equal, "Berlin", "", true);
        //    c2.RowBackColor = Color.FromArgb(165, 244, 36);
        //    c2.RowForeColor = Color.Black;
        //    radGridView1.Columns["City"].ConditionalFormattingObjectList.Add(c2);
        //}

        //private void AddSummaries()
        //{
        //    GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();
        //    GridViewSummaryRowItem item2 = new GridViewSummaryRowItem();

        //    item1.Add(new GridViewSummaryItem("CompanyName", "Count: {0}", GridAggregateFunction.Count));
        //    item2.Add(new GridViewSummaryItem("ContactName", "Count: {0}", GridAggregateFunction.Count));

        //    this.radGridView1.MasterTemplate.SummaryRowsTop.Add(item1);
        //    this.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item2);
        //}

        private void RunExportToExcelML(string fileName, ref bool openExportFile)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(this.radGridView1);

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    excelExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    excelExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            excelExporter.ExportVisualSettings = true;
            excelExporter.ExportHierarchy = true;
            excelExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                excelExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void RunExportToCSV(string fileName, ref bool openExportFile)
        {
            ExportToCSV csvExporter = new ExportToCSV(this.radGridView1);
            csvExporter.CSVCellFormatting += csvExporter_CSVCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    csvExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    csvExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            csvExporter.ExportHierarchy = true;
            csvExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                csvExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to CSV", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void csvExporter_CSVCellFormatting(object sender, Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.CSVCellElement.Value = this.FormatDate(e.CSVCellElement.Value);
            }
        }

        private void RunExportToHTML(string fileName, ref bool openExportFile)
        {
            ExportToHTML htmlExporter = new ExportToHTML(this.radGridView1);
            htmlExporter.HTMLCellFormatting += htmlExporter_HTMLCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    htmlExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            htmlExporter.ExportVisualSettings = true;
            htmlExporter.ExportHierarchy = true;
            htmlExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                htmlExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to HTML", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void htmlExporter_HTMLCellFormatting(object sender, Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.HTMLCellElement.Value = this.FormatDate(e.HTMLCellElement.Value);
            }
        }

        private void RunExportToPDF(string fileName, ref bool openExportFile)
        {
            ExportToPDF pdfExporter = new ExportToPDF(this.radGridView1);
            pdfExporter.PdfExportSettings.Title = "My PDF Title";
            pdfExporter.PdfExportSettings.PageWidth = 297;
            pdfExporter.PdfExportSettings.PageHeight = 210;
            pdfExporter.FitToPageWidth = true;
            pdfExporter.HTMLCellFormatting += pdfExporter_HTMLCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    pdfExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            pdfExporter.ExportVisualSettings = true;
            pdfExporter.ExportHierarchy = true;
            pdfExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                pdfExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to PDF", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }

            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void pdfExporter_HTMLCellFormatting(object sender, Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.HTMLCellElement.Value = this.FormatDate(e.HTMLCellElement.Value);
            }
        }

        private string FormatDate(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.ToString("d MMM yyyy");
            }

            return value.ToString();
        }


        private void radListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Excel (*.xls)|*.xls";

            switch (this.ListViewOption.SelectedIndex)
            {
                case 0: //export to excelML 
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 1: //export to CSV
                    saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 2: //export to HTML
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
                case 3: //export to PDF
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                    this.radComboBoxSummaries.Enabled = true;

                    break;
            }
        }
    }
}
