using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGuitar
{
    class TopVolumeComponent : VolumeComponent
    {
        public int VolumeLevel = 0;
        private int TopVolumeLevel = 11;

        public override void VolumeUp()
        {
            base.VolumeUp();

            if(true)
            {
                // make top volume
                VolumeLevel = TopVolumeLevel;
            }
        }
    }
}
