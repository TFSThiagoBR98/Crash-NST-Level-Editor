namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Trigger_Music_Change_DelayData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Sound_Music_Settings = new();
        [FieldAttr(nst: 48)] public float _Float;
    }
}
