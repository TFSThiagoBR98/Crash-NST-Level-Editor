namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class T502_Back_In_Time_Chicken_Audio_EchoData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Rumble_Data = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity = new();
    }
}
