using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztp4
{
    [Serializable]
    public abstract class  AbstarctPlayerDecorator : AbstractPlayer
    {
        public AbstractPlayer objplayer;
        public override string Role
        {
            get
            {
                return objplayer.Role;
            }
            set
            {
                objplayer.Role = value;
            }
        }

        public AbstarctPlayerDecorator (AbstractPlayer objplayer)
        { 
            this.objplayer = objplayer;
            
        }
      
    }
}
