namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Int_Crash_Game_Variable_Element : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Int_Variable_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Int_Variable_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Int_Variable_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Int_Variable_0x40 = new();
        [FieldAttr(nst: 72)] public ECrashGame _E_Crash_Game;
    }
}
