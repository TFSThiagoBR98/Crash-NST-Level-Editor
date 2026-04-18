namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 72, align: 8)]
    public class igCharMetrics : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public u16 _charNumber;
        [FieldAttr(nst: 20, ctr: 16)] public float _kernLeft;
        [FieldAttr(nst: 24, ctr: 20)] public float _kernRight;
        [FieldAttr(nst: 28, ctr: 24)] public float _step;
        [FieldAttr(nst: 32, ctr: 28)] public igVec2fMetaField _offset = new();
        [FieldAttr(nst: 40, ctr: 36)] public igVec2fMetaField _size = new();
        [FieldAttr(ctr: 44)] public float _boundingHeightMin;
        [FieldAttr(ctr: 48)] public float _boundingHeightMax;
        [FieldAttr(nst: 48, ctr: 52)] public igVec2fMetaField _texCoordMin = new();
        [FieldAttr(nst: 56, ctr: 60)] public igVec2fMetaField _texCoordMax = new();
        [FieldAttr(ctr: 68)] public EBidiType _bidiType;
    }
}
