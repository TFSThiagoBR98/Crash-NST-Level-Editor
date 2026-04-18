namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Oriental_Cart_HazzardData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _Death_State_0x28 = null;
        [FieldAttr(nst: 48)] public string? _Death_State_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 64)] public float _Float;
    }
}
