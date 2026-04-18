namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CSplineCameraTriggerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CSplineCameraData? _blendTargetData;
        [FieldAttr(nst: 32)] public igHandleMetaField _splineTarget = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _splineSource = new();
    }
}
