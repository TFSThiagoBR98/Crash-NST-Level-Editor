namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class common_ShortcutAchievementCancellerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity_Handle_List = new();
    }
}
