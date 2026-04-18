namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class L300_Hub_HiddenDragonTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int;
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 56)] public string? _String = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 72)] public float _Float;
    }
}
