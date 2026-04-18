namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igPitchOverride : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _pitch;
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public CSoundInstance? _owner;
    }
}
