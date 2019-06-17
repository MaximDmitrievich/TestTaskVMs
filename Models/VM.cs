using System;

namespace TestTaskVMs.Models
{
    public class VM 
    {
        public string VirtualServerId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime RemoveDateTime { get; set; }
        public bool SelectedForRemove { get; set; }
    }
}