namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BoltToPlayerWithOffsetData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igVec3fMetaField _Vector3 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_Data = new();
    }
}
