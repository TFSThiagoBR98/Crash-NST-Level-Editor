namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class Multiple_Spawner_Template_c : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _SpawnMultipleWaves;
        [FieldAttr(nst: 41)] public bool _WaitForSpawnTemplateEvent;
        [FieldAttr(nst: 42)] public bool _SpawnAtSpawner;
        [FieldAttr(nst: 43)] public bool _UseTriggerVolume;
        [FieldAttr(nst: 48)] public igHandleMetaField _Spawn_Entity_List = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DependentSpawnersList = new();
        [FieldAttr(nst: 64)] public float _DelayBetweenEntities;
        [FieldAttr(nst: 68)] public float _DelayBetweenSets;
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 88)] public int _Int;
        [FieldAttr(nst: 92)] public bool _Bool_0x5c;
        [FieldAttr(nst: 93)] public bool _Bool_0x5d;
        [FieldAttr(nst: 94)] public bool _Bool_0x5e;
        [FieldAttr(nst: 96)] public float _Float;
        [FieldAttr(nst: 100)] public bool _Bool_0x64;
        [FieldAttr(nst: 104)] public string? _String = null;
    }
}
