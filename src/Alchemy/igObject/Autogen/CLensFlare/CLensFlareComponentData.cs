namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CLensFlareComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CLensFlareList? _flares;
        [FieldAttr(ctr: 24)] public igVec2fMetaField _centerPoint = new();
        [FieldAttr(ctr: 32)] public float _sunOcclusionSize;
        [FieldAttr(ctr: 36)] public float _sunVisibilityMinThreshold;
        [FieldAttr(ctr: 40)] public float _sunVisibilityMaxThreshold;
        [FieldAttr(ctr: 44)] public float _sunOcclusionAdaptivity;
        [FieldAttr(ctr: 48)] public igHandleMetaField _lensFlareGui = new();
    }
}
