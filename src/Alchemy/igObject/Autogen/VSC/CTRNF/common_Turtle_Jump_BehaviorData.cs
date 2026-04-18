namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Turtle_Jump_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect = new();
    }
}
