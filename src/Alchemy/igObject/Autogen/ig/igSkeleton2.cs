namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igSkeleton2 : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igSkeletonBoneList? _boneList;
        [FieldAttr(nst: 32, ctr: 32)] public igMemoryRef<igMatrix44fMetaField> _inverseJointArray = new();
    }
}
