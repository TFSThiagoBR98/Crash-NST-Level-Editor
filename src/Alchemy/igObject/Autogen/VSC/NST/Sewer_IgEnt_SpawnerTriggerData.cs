namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Sewer_IgEnt_SpawnerTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int;
        [FieldAttr(nst: 44)] public float _DelayBetweenActiavations;
        [FieldAttr(nst: 48)] public bool _Bool;
        [FieldAttr(nst: 56)] public igHandleMetaField _igEntity_List = new();
    }
}
