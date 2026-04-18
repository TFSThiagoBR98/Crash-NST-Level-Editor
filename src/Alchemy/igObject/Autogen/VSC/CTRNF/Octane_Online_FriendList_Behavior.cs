namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Online_FriendList_Behavior : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public EIG_CORE_PLATFORM _IG_CORE_PLATFORM;
        [FieldAttr(ctr: 52)] public bool _Bool_0x34;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Localized_String_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Localized_String_0x40 = new();
        [FieldAttr(ctr: 72)] public bool _Bool_0x48;
        [FieldAttr(ctr: 73)] public bool _Bool_0x49;
    }
}
