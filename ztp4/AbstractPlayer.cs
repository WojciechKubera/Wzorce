using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztp4
{
    [Serializable]
    public abstract class  AbstractPlayer 
    {
        public virtual string Role { get; set;}
      
        
        public abstract AbstractPlayer Clone();
        public abstract string GetDescription();
       
    }
}
