namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class COctaneAudioData : igSingleton
    {
        [FieldAttr(ctr: 16)] public COctaneAudioDriverThematicHastTable? _octaneAudioDriverThematic;
    }
}
