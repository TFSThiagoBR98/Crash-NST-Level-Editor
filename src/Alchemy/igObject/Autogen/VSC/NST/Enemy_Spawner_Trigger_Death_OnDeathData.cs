namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Spawner_Trigger_Death_OnDeathData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 56)] public string? _String = null;
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 65)] public bool _Bool_0x41;
        [FieldAttr(nst: 66)] public bool _Bool_0x42;
        [FieldAttr(nst: 67)] public bool _Bool_0x43;
    }
}
