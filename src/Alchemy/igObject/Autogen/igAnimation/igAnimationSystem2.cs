namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igAnimationSystem2 : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igSkeleton2? _skeleton;
        [FieldAttr(nst: 32, ctr: 32)] public igMemoryRef<igMatrix44fMetaField> _concatenatedBoneMatrixArray = new();
        [FieldAttr(nst: 48, ctr: 48)] public igMemoryRef<igMatrix44fMetaField> _concatenatedBlendMatrixArray = new();
        [FieldAttr(nst: 64, ctr: 64)] public int _matrixArrayTime = -2147483648;
    }
}
