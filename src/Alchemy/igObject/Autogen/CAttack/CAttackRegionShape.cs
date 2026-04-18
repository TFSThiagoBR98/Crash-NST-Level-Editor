namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CAttackRegionShape : igObject
    {
        [FieldAttr(nst: 16)] public CShape? _shape;
        [FieldAttr(nst: 24)] public CBoltPoint? _boltPoint;
        [FieldAttr(nst: 32)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 44)] public int _maximumQueryResults = -1;
    }
}
