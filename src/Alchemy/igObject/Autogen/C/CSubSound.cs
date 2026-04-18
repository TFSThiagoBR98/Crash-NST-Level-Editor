namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CSubSound : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _fileName = null;
        [FieldAttr(nst: 24, ctr: 24)] public float _volume = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public u16 _sampleRate = 48000;
        [FieldAttr(nst: 30, ctr: 30)] public i8 _quality = 40;
        [FieldAttr(nst: 31, ctr: 31)] public bool _externalSource;
        [FieldAttr(nst: 32, ctr: 32)] public uint _externalBufferSize;
        [FieldAttr(nst: 36, ctr: 36)] public uint _externalDecodeBufferSamples;
        [FieldAttr(nst: 40, ctr: 40)] public igSound? _igSound;
        [FieldAttr(nst: 48, ctr: 48)] public igSound? _parentIgSound;
        [FieldAttr(nst: 56, ctr: 56)] public u8 _ref;
        [FieldAttr(nst: 57, ctr: 57)] public bool _dirty;
        [FieldAttr(nst: 58, ctr: 58)] public bool _usesVisemes;
    }
}
