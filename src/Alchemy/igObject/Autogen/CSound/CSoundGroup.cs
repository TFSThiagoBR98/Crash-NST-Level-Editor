namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CSoundGroup : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _name = null;
        [FieldAttr(nst: 24, ctr: 24)] public uint _maxPlaybacks;
        [FieldAttr(nst: 28, ctr: 28)] public ESoundGroupPlaybackBehavior _behaviour = ESoundGroupPlaybackBehavior.eSGPB_Mute;
        [FieldAttr(nst: 32, ctr: 32)] public float _fade = 0.75f;
        [FieldAttr(nst: 36, ctr: 36)] public u8 _priority = 64;
        [FieldAttr(nst: 37, ctr: 37)] public bool _mute;
        [FieldAttr(nst: 38, ctr: 38)] public bool _solo;
        [FieldAttr(nst: 40, ctr: 40)] public igRawRefMetaField _soundGroup = new();
    }
}
