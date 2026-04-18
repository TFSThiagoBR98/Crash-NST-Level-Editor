namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Spawner_TemplateData : CVscComponentData
    {
        public enum ENewEnum11_id_6xic0fuw
        {
            None = 0,
            Level = 1,
            Session = 2,
        }

        [FieldAttr(nst: 40)] public bool _ActivateCheckpointLoad;
        [FieldAttr(nst: 41)] public bool _ActivateOnSpawn;
        [FieldAttr(nst: 42)] public bool _RespawnOnDeath;
        [FieldAttr(nst: 43)] public bool _SpawnOnEnter;
        [FieldAttr(nst: 44)] public bool _WaitForSpawnTemplateEvent;
        [FieldAttr(nst: 48)] public igHandleMetaField _SpawnAtEntity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _UsedEntityToSpawn = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _TriggerVolume = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _EntityToSpawn = new();
        [FieldAttr(nst: 80)] public float _InitialDelay;
        [FieldAttr(nst: 84)] public float _DeathRespawnTimer;
        [FieldAttr(nst: 88)] public bool _Bool_0x58;
        [FieldAttr(nst: 89)] public bool _Bool_0x59;
        [FieldAttr(nst: 92)] public ENewEnum11_id_6xic0fuw _NewEnum11_id_6xic0fuw;
        [FieldAttr(nst: 96)] public bool _Bool_0x60;
        [FieldAttr(nst: 97)] public bool _Bool_0x61;
        [FieldAttr(nst: 98)] public bool _Bool_0x62;
    }
}
