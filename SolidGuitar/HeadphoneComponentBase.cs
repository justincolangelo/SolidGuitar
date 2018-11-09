using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGuitar
{
    public abstract class HeadphoneComponentBase : IHeadphoneComponent
    {
        // 
        public virtual void OutputToHeadphones()
        {
            throw new NotImplementedException();
        }
    }
}
