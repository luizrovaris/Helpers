using System;

namespace PoC.BrachControl.DTO
{
    public class BranchDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Origin { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ReleaseDev { get; set; }
        public DateTime? ReleaseTst { get; set; }
        public DateTime? ReleasePp { get; set; }
        public DateTime? ReleaseProd { get; set; }
        public bool Active { get; set; }
    }
}
