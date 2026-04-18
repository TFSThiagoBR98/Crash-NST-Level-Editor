namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CPhysicsSystemSkeletonBinding : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<int> _boneToBodyArray = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<i16> _boneToParentDynamicBlendIndexArray = new();
        [FieldAttr(nst: 64, ctr: 64)] public bool _hasKeyframedBodies;
        [FieldAttr(nst: 65, ctr: 65)] public bool _hasDynamicBodies;
    }
}
