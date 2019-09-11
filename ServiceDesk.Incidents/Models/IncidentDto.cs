using ServiceDesk.Incidents.Selector;
using ServiceDesk.SmartUI.FormAttribute;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.Incidents.Models
{
    public class IncidentDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Archive { get; set; }
        [DropdownList(typeof(BranchSelector))]
        [Required]
        public string Branch { get; set; }
        public ShareType ShareType { get; set; }
    }

    public enum ShareType
    {
        Internal,
        External
    }

}
