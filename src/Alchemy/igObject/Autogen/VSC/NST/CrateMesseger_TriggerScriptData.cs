namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class CrateMesseger_TriggerScriptData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _SpawnerActivationList = new();
        [FieldAttr(nst: 48)] public float _DelayBetweenActiavations;
    }
}
