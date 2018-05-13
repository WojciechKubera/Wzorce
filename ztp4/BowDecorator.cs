using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztp4
{
    [Serializable]
    class BowDecorator : AbstarctPlayerDecorator
    {
        
        public BowDecorator(AbstractPlayer player)
                  : base(player)
        {
        }

        public override AbstractPlayer Clone() => this.DeepClone();
        
        
        public override string GetDescription()
        {
            return this.objplayer.GetDescription() + ",<BR>player is equipped with Bow";
        }
    }
}

