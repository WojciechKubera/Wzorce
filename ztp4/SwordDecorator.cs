using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ztp4
{
    [Serializable]
    class SwordDecorator : AbstarctPlayerDecorator
    {
        public SwordDecorator(AbstractPlayer player)
                  : base(player)
        {
           
        }

        public override AbstractPlayer Clone() => this.DeepClone();

        public override string GetDescription()
        {
            return objplayer.GetDescription() + ",<BR> player is equipped with Sword";
        }
    }
}
