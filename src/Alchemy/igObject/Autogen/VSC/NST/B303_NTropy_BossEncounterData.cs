namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class B303_NTropy_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
    }
}
