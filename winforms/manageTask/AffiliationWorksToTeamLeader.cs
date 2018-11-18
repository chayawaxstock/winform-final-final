using manageTask.Logic;
using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace manageTask
{
    public partial class AffiliationWorksToTeamLeader : Telerik.WinControls.UI.RadForm
    {
        public AffiliationWorksToTeamLeader()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void AffiliationWorksToTeamLeader_Load_1(object sender, EventArgs e)
        {
            List<User> workers = UserRequests.getSimpleWorkers();
            if (workers != null)
            {
                cmbx_worker.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    cmbx_worker.Items.Add(getItemWorker( worker));
                }
            }

        }

        public RadListDataItem getItemWorker(User worker)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = worker.UserName;
            item.Tag = worker;
            return item;
        }

        private void cmbx_worker_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_team.Items.Clear();

            cmbx_team.Visible = true;
            lbl_team.Visible = true;
            btn_workerToTeamleader.Visible = true;

            List<User> teamLeaders = UserLogic.getUserByDepartment("teamLeader");
            if (teamLeaders != null)
            {
                cmbx_team.DisplayMember = "UserName";
                foreach (User user in teamLeaders)
                {
                    cmbx_team.Items.Add(user);
                }
            }

        }



        private void btn_workerToTeamleader_Click(object sender, EventArgs e)
        {

            User editUser = new User();
            editUser = (cmbx_worker.SelectedItem as User);
            editUser.ManagerId = (cmbx_team.SelectedItem as User).UserId;
            try
            {
                var httpResponse = UserLogic.updateUser(editUser);
                if (httpResponse.StatusDescription == "OK")
                {
                    RadMessageBox.SetThemeName("MaterialTeal");
                    RadMessageBox.Show("sucsess", "error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else MessageBox.Show("ERROR!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("cant affiliation the worker to team leader");
            }
        }
    }
}
