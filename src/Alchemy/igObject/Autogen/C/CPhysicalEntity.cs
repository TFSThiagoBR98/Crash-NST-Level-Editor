namespace Alchemy
{
    [ObjectAttr(nst: 296, ctr: 296, align: 8)]
    public class CPhysicalEntity : CGameEntity
    {
        [ObjectAttr(size: 1)]
        public class RuntimeFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _removeOnDeath = true;
            [FieldAttr(offset: 1, size: 1)] public bool _netDeath;
            [FieldAttr(offset: 2, size: 1)] public bool _hasDied;
            [FieldAttr(offset: 3, size: 1)] public bool _immunityCallbackRegistered;
        }

        [FieldAttr(nst: 224, ctr: 224)] public igVectorMetaField<CHealthObject> _healthObjects = new();
        [FieldAttr(nst: 248, ctr: 248)] public int _healthMax = -1;
        [FieldAttr(nst: 252, ctr: 252)] public int _unadjustedMaxHealth = -1;
        [FieldAttr(nst: 256, ctr: 256)] public float _lastBeamAttackedTime;
        [FieldAttr(nst: 260, ctr: 260)] public EVulnerability _vulnerability = EVulnerability.eV_Invalid;
        [FieldAttr(nst: 264, ctr: 264)] public CEnableRequestManager? _invulnerable;
        [FieldAttr(nst: 272, ctr: 272)] public CAttackNumberTimestampTable? _recentAttackNumberTimestampTable;
        [FieldAttr(nst: 280, ctr: 280)] public CAttackImmunityTimestampTable? _recentAttackImmunityTimestampTable;
        [FieldAttr(nst: 288, ctr: 288)] public RuntimeFlags _runtimeFlags = new();
    }
}
