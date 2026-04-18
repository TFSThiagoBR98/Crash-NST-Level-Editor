namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 88, align: 8)]
    public class CVfxDrawSoundOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _attackSound = new();
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _sustainSound = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _releaseSound = new();
        [FieldAttr(nst: 56, ctr: 48)] public string? _attackSoundName = null;
        [FieldAttr(nst: 64, ctr: 56)] public string? _sustainSoundName = null;
        [FieldAttr(nst: 72, ctr: 64)] public string? _releaseSoundName = null;
        [FieldAttr(nst: 80, ctr: 72)] public bool _stopOneShotsOnEnd;
        [FieldAttr(nst: 84, ctr: 76)] public float _updateFrequency = 1.0f;
        [FieldAttr(nst: 88, ctr: 80)] public uint _primitiveData;
    }
}
