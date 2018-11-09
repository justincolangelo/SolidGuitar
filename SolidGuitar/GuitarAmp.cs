using System;
using System.Collections.Generic;
using System.Text;

namespace SolidGuitar
{
    public class GuitarAmp : IGuitarAmp
    {
        private IVolumeComponent _volumeComponent;
        private IHeadphoneComponent _headphoneComponent;
        private FootswitchComponent _footswitchComponent;
        private SpecialEffectsComponent _specialEffectsComponent;

        public GuitarAmp(IVolumeComponent volumeComponent, IHeadphoneComponent headphoneComponent, 
            FootswitchComponent footswitchComponent, SpecialEffectsComponent specialEffectsComponent)
        {
            _volumeComponent = volumeComponent;
            _headphoneComponent = headphoneComponent;
            _footswitchComponent = footswitchComponent;
            _specialEffectsComponent = specialEffectsComponent;
        }
        
        public void PlaySomething()
        {
            _volumeComponent.VolumeUp();
            _volumeComponent.VolumeUp();
            _volumeComponent.VolumeUp();

            _footswitchComponent.HandleFootswitchPress();
            _specialEffectsComponent.AddSpecialEffects();
        }
        

        
    }
}
