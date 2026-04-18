namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class Octane_StartScreen_PodiumData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Cutscene_Camera = new();
    }
}
