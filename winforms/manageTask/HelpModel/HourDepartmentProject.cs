using manageTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.HelpModel
{
   public class HourDepartmentProject
    {
        public HourDepartmentProject()
        {
            WorkersHours = new List<ProjectWorker>();
        }
        public int IdDepartment { get; set; }
        public string Department { get; set; }
        public int NumWorkers { get; set; }
        public decimal NumFinishWork { get; set; }
        public decimal NumStayWork { get; set; }

        public List<ProjectWorker> WorkersHours { get; set; }
    }
}
