namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CSurfaceVfxComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public SurfaceVfxSpecList? _surfaceVfxs;
        [FieldAttr(ctr: 24)] public SurfaceVfxSpecList? _landingVfxs;
        [FieldAttr(ctr: 32)] public CSurfaceMaterialAccumulationOverrideList? _surfaceAccumulationOverrides;
        [FieldAttr(ctr: 40)] public bool _canDriveIntoWater;
    }
}
