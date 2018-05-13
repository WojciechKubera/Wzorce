using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace ztp4
{
    [Serializable]
    class Character : AbstractPlayer
    {
        public override AbstractPlayer Clone() => this.DeepClone();
        
        public override string GetDescription()
        {
            return "Player charatters role is " + Role;
        }
    }
}
