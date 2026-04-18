namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_bike_race_position_trackerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Gui_Project = new();
    }
}
