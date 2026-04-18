namespace Alchemy
{
    [ObjectAttr(nst: 976, ctr: 976, align: 16)]
    public class CMobileSceneRenderPass : igForwardLitRenderPass
    {
        public enum EFilterType
        {
            eFT_Default = 0,
            eFT_IncludeFading = 1,
            eFT_ExcludeFading = 2,
        }

        [FieldAttr(nst: 528, ctr: 520)] public EFilterType _filterType;
        [FieldAttr(nst: 536, ctr: 528)] public string? _shadowCameraName = null;
        [FieldAttr(nst: 544, ctr: 536)] public igHandleMetaField _pointLights = new();
        [FieldAttr(nst: 552, ctr: 544)] public int _allocatorCapacity = 8192;
        [FieldAttr(nst: 560, ctr: 560)] public igFrustumCullerMetaField _projectiveShadowFrustum = new();
        [FieldAttr(nst: 960, ctr: 960)] public igVec4fAtomicLinearAllocator[] _pointLightDataAllocator = new igVec4fAtomicLinearAllocator[2];
    }
}
