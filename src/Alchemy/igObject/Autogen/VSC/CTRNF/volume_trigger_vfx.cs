namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class volume_trigger_vfx : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _SteamBlower_BehaviorDatas = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 48)] public float _SteamBlower_BehaviorDatas002;
        [FieldAttr(ctr: 52)] public float _Float;
        [FieldAttr(ctr: 56)] public bool _Bool_0x38;
        [FieldAttr(ctr: 57)] public bool _Bool_0x39;
        [FieldAttr(ctr: 58)] public bool _Bool_0x3a;
    }
}
