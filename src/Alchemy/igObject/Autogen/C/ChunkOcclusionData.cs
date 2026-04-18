namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class ChunkOcclusionData : igObject
    {
        [FieldAttr(ctr: 16)] public igObject? _chunk;
        [FieldAttr(ctr: 24)] public CStaticComponentList? _staticComponentList;
        [FieldAttr(ctr: 32)] public CBoxLightComponentList? _boxLightComponentList;
        [FieldAttr(ctr: 40)] public CPointLightComponentList? _pointLightComponentList;
        [FieldAttr(ctr: 48)] public CTintSphereComponentList? _tintSphereComponentList;
        [FieldAttr(ctr: 56)] public igComponentList? _unoptimizedComponentList;
        [FieldAttr(ctr: 64)] public CGameEntityHandleList? _dynamicEntities;
        [FieldAttr(ctr: 72)] public CGameEntityHandleList? _messageReceivingEntities;
    }
}
