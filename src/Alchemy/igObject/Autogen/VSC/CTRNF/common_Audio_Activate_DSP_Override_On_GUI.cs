namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Audio_Activate_DSP_Override_On_GUI : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igObject? _InternalStore_prioritySetHandler = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Priority_Dsp_Override_Set = new();
    }
}
