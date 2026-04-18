namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CHavokQuerySourceData : CSourceData
    {
        [FieldAttr(nst: 16)] public float _raycastOffsetAbove = 1000.0f;
        [FieldAttr(nst: 20)] public float _raycastOffsetBelow = 1000.0f;
        [FieldAttr(nst: 24)] public igHandleMetaField _targetWaterSurfaceMaterial = new();
    }
}
