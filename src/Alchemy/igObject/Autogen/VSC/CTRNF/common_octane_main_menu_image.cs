namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_octane_main_menu_image : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 48)] public EigGuiAnimationLoopMode _Gui_Animation_Loop_Mode;
        [FieldAttr(ctr: 56)] public igObject? _InternalStore_updateNodeUpdater = new();
        [FieldAttr(ctr: 64)] public bool _Bool_0x40;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(ctr: 88)] public bool _Bool_0x58;
    }
}
