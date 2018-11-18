using manageTask.Logic;
using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace manageTask
{
    public partial class GraphHoursStatus : Telerik.WinControls.UI.RadForm
    {
        public GraphHoursStatus()
        {
            InitializeComponent();
        }

        private void GraphHoursStatus_Load(object sender, EventArgs e)
        {


            List<Project> projects = TaskRequests.getAllProjects();
            if (projects != null)
            {

                dropDown_projects.DisplayMember = "ProjectName";
                foreach (var item in projects)
                {
                    dropDown_projects.Items.Add(getItemProject(item));
                }
            }

          

        }

        public RadListDataItem getItemProject(Project project)
        {
            RadListDataItem item = new RadListDataItem();
            item.Tag = project;
            item.Text = project.ProjectName;
            return item;
        }

        private void dropDown_projects_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Dictionary<string, decimal> workersDictionary = new Dictionary<string, decimal>();
            int idProjectSelect = (dropDown_projects.SelectedItem.Tag as Project).ProjectId;

            List<SumHoursDoneUser> sumHoursDoneUsers = UserLogic.getSumHoursDoneForUsers(idProjectSelect);
            if (sumHoursDoneUsers != null)
            {

                foreach (SumHoursDoneUser sumHoursDoneUser in sumHoursDoneUsers)
                {

                    workersDictionary.Add(sumHoursDoneUser.Label, sumHoursDoneUser.Data);
                }
                chart1.Series[0].Points.DataBindXY(workersDictionary.Keys, workersDictionary.Values);
            }
        }
    }
}
