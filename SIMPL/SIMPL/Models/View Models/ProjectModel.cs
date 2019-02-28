using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMPL.Models.View_Models
{
    public class ProjectModel
    {
        string projectName { get; set; }
        string projectManager { get; set; }
        string projectStartDate { get; set; }
        string projectDescription { get; set; }
        string projectEstEndDate { get; set; }
        string projectEstCost { get; set; }
        string projectActCost { get; set; }
        List<TaskModel> projectTaskList = new List<TaskModel>();      
    }
}
