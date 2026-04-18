namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igSkeletonBone : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public int _parentIndex;
        [FieldAttr(nst: 28, ctr: 28)] public int _blendMatrixIndex = -1;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fMetaField _translation = new();
    }
}
