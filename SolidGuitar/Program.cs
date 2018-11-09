using System;

namespace SolidGuitar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get me a guitar amp with top volume...");

            // Liskov subsititution in this case TopVolume can be used in place of Volume
            GuitarAmp amp = new GuitarAmp(
                new TopVolumeComponent(),
                new BestHeadphoneComponent(), // using abstract implementation
                new FootswitchComponent(),
                new SpecialEffectsComponent()
            );
        }
    }
}
