namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CGroundMaterialChangedMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public igHandleMetaField _newMaterial = new();
    }
}
