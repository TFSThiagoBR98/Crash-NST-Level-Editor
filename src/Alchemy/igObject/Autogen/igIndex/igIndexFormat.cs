namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class igIndexFormat : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EIG_INDEX_TYPE _indexType = EIG_INDEX_TYPE.INT16;
        [FieldAttr(nst: 20, ctr: 16)] public EIG_GFX_PLATFORM _platform;
        [FieldAttr(nst: 24, ctr: 20)] public uint _headerSize;
        [FieldAttr(nst: 28, ctr: 24)] public uint _alignment = 4;
        [FieldAttr(nst: 32, ctr: 28)] public bool _hasRestartIndices;
        [FieldAttr(nst: 33, ctr: 29)] public bool _dynamic;
    }
}
