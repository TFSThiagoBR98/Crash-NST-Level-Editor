namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Online_FriendList_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Material = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 56)] public bool _Bool_0x38;
        [FieldAttr(ctr: 57)] public bool _Bool_0x39;
    }
}
