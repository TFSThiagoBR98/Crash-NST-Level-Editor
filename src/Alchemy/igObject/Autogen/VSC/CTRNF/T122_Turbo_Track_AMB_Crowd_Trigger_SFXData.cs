namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T122_Turbo_Track_AMB_Crowd_Trigger_SFXData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
    }
}
