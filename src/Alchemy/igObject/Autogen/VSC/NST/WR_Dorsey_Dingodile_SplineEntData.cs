namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class WR_Dorsey_Dingodile_SplineEntData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_Handle_List = new();
    }
}
