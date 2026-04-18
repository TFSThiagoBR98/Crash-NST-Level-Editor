namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class CRenderBaseConstantBundles : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CCameraConstantBundle[] _cameraConstantBundle = new CCameraConstantBundle[2];
        [FieldAttr(nst: 32, ctr: 32)] public CColorAdjustmentBundle[] _colorAdjustmentBundle = new CColorAdjustmentBundle[2];
        [FieldAttr(nst: 48, ctr: 48)] public CEnvironmentLightingBundle[] _environmentLightingBundle = new CEnvironmentLightingBundle[2];
        [FieldAttr(nst: 64, ctr: 64)] public CGlobalWindShaderConstantBundle[] _globalWindConstantBundle = new CGlobalWindShaderConstantBundle[2];
        [FieldAttr(nst: 80, ctr: 80)] public CNextGenStateBundle[] _nextGenStateBundle = new CNextGenStateBundle[2];
        [FieldAttr(nst: 96, ctr: 96)] public C4kStateBundle[] _fourkStateBundle = new C4kStateBundle[2];
        [FieldAttr(nst: 112, ctr: 112)] public igOutdoorLightConstantBundle[] _outdoorLightConstantBundle = new igOutdoorLightConstantBundle[2];
    }
}
