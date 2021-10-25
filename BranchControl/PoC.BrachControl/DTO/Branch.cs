using Newtonsoft.Json;
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
        public string Scripts { get; set; }
        public string Configs { get; set; }

        [JsonIgnore]
        public bool HasScripts
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.Scripts);
            }
        }

        [JsonIgnore]
        public bool HasConfigs
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.Configs);
            }
        }

        [JsonIgnore]
        public string Env
        {
            get
            {
                string env = "local";
                if (this.ReleaseProd.HasValue)
                {
                    env = "Prod";
                }
                else if (this.ReleasePp.HasValue)
                {
                    env = "PP";
                }
                else if (this.ReleaseTst.HasValue)
                {
                    env = "TST";
                }
                else if (this.ReleaseDev.HasValue)
                {
                    env = "Dev";
                }

                return env;
            }
        }
    }
}
