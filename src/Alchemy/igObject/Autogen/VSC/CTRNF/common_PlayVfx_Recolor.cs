namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PlayVfx_Recolor : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _SteamBlower_BehaviorDatas = new();
        [FieldAttr(ctr: 40)] public igVec4ucMetaField _Color = new();
        [FieldAttr(ctr: 44)] public bool _Bool;
    }
}
