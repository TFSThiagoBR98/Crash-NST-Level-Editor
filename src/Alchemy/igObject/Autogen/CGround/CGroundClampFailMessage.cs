namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGroundClampFailMessage : CEntityMessage
    {
        [FieldAttr(ctr: 56)] public EGroundClampFailReason _reason;
        [FieldAttr(ctr: 60)] public igVec3fMetaField _mostRecentSuccessPosition = new();
    }
}
