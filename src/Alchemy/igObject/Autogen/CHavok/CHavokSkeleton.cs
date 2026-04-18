namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CHavokSkeleton : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igSkeleton2? _alchemySkeleton;
        [FieldAttr(nst: 24, ctr: 24)] public igRawRefMetaField _havokSkeleton = new();
        [FieldAttr(nst: 32, ctr: 32)] public igIntIntHashTable? _boneIndexMap;
        [FieldAttr(nst: 40, ctr: 40)] public int _loadCount;
    }
}
