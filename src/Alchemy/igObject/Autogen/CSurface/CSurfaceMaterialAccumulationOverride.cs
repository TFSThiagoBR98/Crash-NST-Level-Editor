namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CSurfaceMaterialAccumulationOverride : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(ctr: 24)] public CSurfaceMaterialAccumulationData? _surfaceAccumulation;
        [FieldAttr(ctr: 32)] public float _initialAccumulation;
    }
}
