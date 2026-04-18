namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Spawner_Trigger_LogicData : CVscComponentData
    {
        public enum ENewEnum4_id_daqgq2qt
        {
            SpawnWithDefaultActivation = 0,
            SpawnAndForceActivation = 1,
            ForceActivateExistingEntity = 2,
            SpawnDefaultActivationORForceActivateExistingEntity = 3,
            ForceAttackExistingEntity = 4,
            ForceTellExistingEntity = 5,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _SpawnerActivationList = new();
        [FieldAttr(nst: 48)] public float _DelayBetweenActiavations;
        [FieldAttr(nst: 52)] public ENewEnum4_id_daqgq2qt _NewEnum4_id_daqgq2qt;
        [FieldAttr(nst: 56)] public int _Int;
        [FieldAttr(nst: 60)] public bool _Bool_0x3c;
        [FieldAttr(nst: 61)] public bool _Bool_0x3d;
    }
}
