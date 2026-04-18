namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igAnimationBinding2 : igObject
    {
        public enum EReflectionType
        {
            kReflectNone = 0,
            kReflectPlaneYZ = 1,
            kReflectPlaneXZ = 2,
            kReflectPlaneXY = 3,
        }

        [FieldAttr(nst: 16, ctr: 16)] public igSkeleton2? _skeleton;
        [FieldAttr(nst: 24, ctr: 24)] public igMemoryRef<int> _boneTransformSourceIndexArray = new();
        [FieldAttr(nst: 40, ctr: 40)] public int _bindCount;
        [FieldAttr(nst: 48, ctr: 48)] public igIntList? _chainSwapList;
        [FieldAttr(nst: 56, ctr: 56)] public igBitMask? _reflectionMask;
    }
}
