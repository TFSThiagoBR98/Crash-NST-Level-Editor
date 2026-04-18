namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Castle_Hazard_SwingingAxe_LogicData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _ConstantDelay;
        [FieldAttr(nst: 44)] public float _StartDelay;
        [FieldAttr(nst: 48)] public igHandleMetaField _SwingingAxeSound = new();
    }
}
