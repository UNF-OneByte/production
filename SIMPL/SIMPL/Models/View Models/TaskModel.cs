using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMPL.Models.View_Models
{
    public class TaskModel
    {
        string Name { get; set; }
        string Description { get; set; }
        string CreatedById { get; set; }
        int TaskId { get; set; }
        int ProjectId { get; set; }
        int VendorId { get; set; }
        int LocationId { get; set; }
        int CostTypleId { get; set; }
        DateTime DateCreated { get; set; }
        decimal EstimatedCost { get; set; }
        decimal ActualCost { get; set; }
        decimal EstimatedHours{ get; set; }
        decimal ActualHours { get; set; }
    }
}
