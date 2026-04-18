namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class L330_RingsOfPower_Race_TrackerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
    }
}
