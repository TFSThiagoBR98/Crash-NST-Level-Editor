namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CVfxFont : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CCharacterInfoHashTable? _characterInfo;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _textEffect = new();
        [FieldAttr(nst: 32, ctr: 32)] public int _vfxTrackParameterIndex = 1;
        [FieldAttr(nst: 36, ctr: 36)] public float _defaultCharacterWidth;
        [FieldAttr(nst: 40, ctr: 40)] public int _numFrames = 1;
        [FieldAttr(nst: 44, ctr: 44)] public float _lineHeight;
    }
}
