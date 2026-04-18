namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CPlayerRespawnStartMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public igHandleMetaField _playerActor = new();
        [FieldAttr(nst: 64)] public CPlayerRespawnComponent.ERespawnType _respawnType = CPlayerRespawnComponent.ERespawnType.eRT_Unknown;
    }
}
