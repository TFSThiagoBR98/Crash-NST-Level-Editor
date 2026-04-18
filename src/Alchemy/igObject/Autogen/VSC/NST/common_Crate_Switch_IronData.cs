namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crate_Switch_IronData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _OulinedCrates = new();
        [FieldAttr(nst: 48)] public float _ChangeDelay;
        [FieldAttr(nst: 52)] public float _Float;
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
    }
}
