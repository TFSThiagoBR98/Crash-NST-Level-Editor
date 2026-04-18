namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_NFBoostBar_BoostType : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public float _Float_0x28;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Animation_Tag_0x40 = new();
        [FieldAttr(ctr: 72)] public float _Float_0x48;
        [FieldAttr(ctr: 76)] public float _Float_0x4c;
    }
}
