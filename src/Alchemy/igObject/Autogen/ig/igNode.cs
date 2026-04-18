namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igNode : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVolume? _bound;
        [FieldAttr(nst: 32, ctr: 32)] public igNonRefCountedNodeList? _parentList;
        [FieldAttr(nst: 40, ctr: 40)] public i16 _traversalWeight = -1;
        [FieldAttr(nst: 42, ctr: 42)] public i16 _traversalSpuWeight = -1;
        [FieldAttr(nst: 44, ctr: 44)] public int _handle = -1;
        [FieldAttr(nst: 48, ctr: 48)] public int _flags;
    }
}
