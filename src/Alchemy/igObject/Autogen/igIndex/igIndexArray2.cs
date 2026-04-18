namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 72, align: 8)]
    public class igIndexArray2 : igBaseIndexArray
    {
        [FieldAttr(nst: 80)] public igRawRefMetaField _dxIndexBuffer = new();
        [FieldAttr(nst: 88)] public uint _dxFormat;
        [FieldAttr(nst: 92)] public bool _dirty = true;
    }
}
