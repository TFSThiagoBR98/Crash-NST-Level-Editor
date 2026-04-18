namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8)]
    public class CLoopingMultiIntensityVfxComponentData : CLoopingVfxComponentData
    {
        [FieldAttr(nst: 80)] public igHandleMetaField _effect_1 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _multiIntensityVfxEffect = new();
        [FieldAttr(nst: 96)] public VfxIntensityLayersList? _intensityLayers;
        [FieldAttr(nst: 104)] public igHandleMetaField _managerComponentEntity = new();
        [FieldAttr(nst: 112)] public CMultiIntensityVfxManagerComponentData? _managerComponentData;
    }
}
