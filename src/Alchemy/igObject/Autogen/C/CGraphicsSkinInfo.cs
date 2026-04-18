namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class CGraphicsSkinInfo : igInfo
    {
        [FieldAttr(nst: 40, ctr: 40)] public igSkeleton2? _skeleton;
        [FieldAttr(nst: 48, ctr: 48)] public igModelData? _skin;
        [FieldAttr(nst: 56, ctr: 56)] public igStringIntHashTable? _boltPointIndexArray;
        [FieldAttr(nst: 64, ctr: 64)] public CHavokSkeleton? _havokSkeleton;
        [FieldAttr(nst: 72, ctr: 72)] public igVec3fMetaField _boundsMin = new();
        [FieldAttr(nst: 84, ctr: 84)] public igVec3fMetaField _boundsMax = new();
    }
}
