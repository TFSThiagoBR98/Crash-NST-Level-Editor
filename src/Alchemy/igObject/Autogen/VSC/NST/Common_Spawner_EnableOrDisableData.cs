namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_Spawner_EnableOrDisableData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _EnableOnEnter;
        [FieldAttr(nst: 41)] public bool _DisableOnExit;
        [FieldAttr(nst: 42)] public bool _DisableOnEnter;
        [FieldAttr(nst: 43)] public bool _EnableOnExit;
        [FieldAttr(nst: 48)] public igHandleMetaField _TriggerVolume = new();
        [FieldAttr(nst: 56)] public float _Initial_Delay_On_Enter;
        [FieldAttr(nst: 60)] public bool _Bool;
    }
}
