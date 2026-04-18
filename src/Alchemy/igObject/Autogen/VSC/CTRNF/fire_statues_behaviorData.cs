namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class fire_statues_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public float _Float_0x28;
        [FieldAttr(ctr: 44)] public float _Float_0x2c;
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound = new();
    }
}
