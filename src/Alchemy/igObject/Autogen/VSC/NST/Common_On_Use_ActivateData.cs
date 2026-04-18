namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_On_Use_ActivateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(nst: 48)] public bool _Bool_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 80)] public string? _String = null;
    }
}
