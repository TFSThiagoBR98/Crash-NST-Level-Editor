namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CDynamicCheckpointComponent : CEntityComponent
    {
        [FieldAttr(nst: 48)] public CCheckpoint? _dynamicCheckpoint;
        [FieldAttr(nst: 56)] public CPlayerStartEntity? _dynamicPlayerStart;
        [FieldAttr(nst: 64)] public igHandleMetaField _handleRespawnFunction = new();
    }
}
