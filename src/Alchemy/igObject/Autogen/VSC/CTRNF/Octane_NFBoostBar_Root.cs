namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_NFBoostBar_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EOctaneBoostBarType _E_Octane_Boost_Bar_Type;
        [FieldAttr(ctr: 44)] public float _Float_0x2c;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Placeable_0x48 = new();
        [FieldAttr(ctr: 80)] public float _Float_0x50;
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Placeable_0x58 = new();
        [FieldAttr(ctr: 96)] public int _Int;
        [FieldAttr(ctr: 100)] public float _Float_0x64;
        [FieldAttr(ctr: 104)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 120)] public bool _Bool;
    }
}
