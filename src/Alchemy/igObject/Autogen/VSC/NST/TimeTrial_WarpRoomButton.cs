namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class TimeTrial_WarpRoomButton : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 48)] public igObject? _InternalStore__gate = new();
    }
}
