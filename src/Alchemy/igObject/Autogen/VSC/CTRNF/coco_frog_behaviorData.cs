namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class coco_frog_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Spline_Event = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity = new();
    }
}
