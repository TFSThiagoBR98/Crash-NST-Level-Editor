namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Hint_DisplayData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Localized_String_List = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public bool _Bool;
    }
}
