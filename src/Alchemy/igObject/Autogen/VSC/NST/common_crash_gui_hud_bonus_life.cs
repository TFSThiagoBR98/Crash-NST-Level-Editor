namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_crash_gui_hud_bonus_life : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Spawned_Vfx_EffectVariable = new();
        [FieldAttr(nst: 48)] public int _Int;
        [FieldAttr(nst: 56)] public igObject? _InternalStore_sliderData_0x38 = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
        [FieldAttr(nst: 72)] public igObject? _InternalStore_sliderData_0x48 = new();
    }
}
