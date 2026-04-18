namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CPlayerOnSupportingEntityMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public igHandleMetaField _supportingEntity = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _lastSupportingEntity = new();
        [FieldAttr(nst: 72)] public EPlayerSupportType _supportType;
    }
}
