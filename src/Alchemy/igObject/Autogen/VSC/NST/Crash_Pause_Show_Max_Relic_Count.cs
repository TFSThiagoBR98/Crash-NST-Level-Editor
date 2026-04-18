namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Crash_Pause_Show_Max_Relic_Count : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Int_Variable_0x28 = new();
        [FieldAttr(nst: 48)] public ECrashGame _E_Crash_Game;
        [FieldAttr(nst: 52)] public int _Int;
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Int_Variable_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Int_Variable_0x40 = new();
    }
}
