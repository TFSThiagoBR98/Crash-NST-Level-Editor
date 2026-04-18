namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Gui_CrashSecretEnding_Manager : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(nst: 56)] public igObject? _Localized_String = new();
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 72)] public igHandleMetaField _Gui_Animation_Tag_0x48 = new();
    }
}
