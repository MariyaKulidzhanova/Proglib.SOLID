using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proglib.SOLID
{
    using System.Collections.Generic;

    public class UObject
    {
        public string Id { get; set; }
        public string Action { get; set; }
        public Dictionary<string, int> Parameters { get; set; } = new Dictionary<string, int>();

        public void SetVelocity(int velocity)
        {
            Parameters["velocity"] = velocity;
        }

        public void RemoveVelocity()
        {
            Parameters.Remove("velocity");
        }
    }
}