namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 16)]
    public class CVfxRaycastOperator : igVfxFrameOperator
    {
        public enum EFailAction
        {
            UseCurrent = 0,
            UseStart = 1,
            UseEnd = 2,
            UseHide = 3,
            UseKill = 4,
        }

        public enum EHitFacing
        {
            FaceRay = 0,
            FaceSurfaceNormal = 1,
            FaceReflection = 2,
        }

        [ObjectAttr(size: 4)]
        public class RaycastFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public CVfxRaycastOperator.EFailAction _failAction;
            [FieldAttr(offset: 3, size: 2)] public CVfxRaycastOperator.EHitFacing _hitFacing = CVfxRaycastOperator.EHitFacing.FaceRay;
            [FieldAttr(offset: 5, size: 1)] public bool _hitFacingFlip;
        }

        [FieldAttr(nst: 32, ctr: 20)] public RaycastFlags _raycastFlags = new();
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _testRay = new();
        [FieldAttr(nst: 64, ctr: 48)] public float _balance;
        [FieldAttr(nst: 68, ctr: 52)] public uint _collisionFlags = 320;
        [FieldAttr(nst: 72, ctr: 56)] public uint _instance;
    }
}
