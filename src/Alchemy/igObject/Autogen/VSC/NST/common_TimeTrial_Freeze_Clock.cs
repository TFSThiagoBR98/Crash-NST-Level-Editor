namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_TimeTrial_Freeze_Clock : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public bool _Bool;
        [FieldAttr(nst: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound_0x48 = new();
    }
}
