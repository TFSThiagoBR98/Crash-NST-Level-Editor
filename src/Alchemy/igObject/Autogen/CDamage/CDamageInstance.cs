namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 8)]
    public class CDamageInstance : igObject
    {
        [FieldAttr(nst: 16)] public CDamageData? _data;
        [FieldAttr(nst: 24)] public bool _dataIsPersistent = true;
        [FieldAttr(nst: 32)] public igHandleMetaField _attacker = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _victim = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _defender = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _source = new();
        [FieldAttr(nst: 64)] public bool _succeeded = true;
        [FieldAttr(nst: 65)] public bool _missed;
        [FieldAttr(nst: 68)] public int _damageAmount = 1;
        [FieldAttr(nst: 72)] public uint _damageMods;
        [FieldAttr(nst: 76)] public bool _allowFriendlyFire;
        [FieldAttr(nst: 80)] public int _attackNumber;
        [FieldAttr(nst: 84)] public igVec3fMetaField _hitLocation = new();
        [FieldAttr(nst: 96)] public igVec3fMetaField _hitDirection = new();
        [FieldAttr(nst: 108)] public bool _spawnHitFx = true;
        [FieldAttr(nst: 112)] public igVec3fMetaField _collisionNormal = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 136)] public igNamedObject? _attackIdentifier;
        [FieldAttr(nst: 144)] public float _knockawayImpulseMin;
        [FieldAttr(nst: 148)] public float _knockawayImpulseMax;
        [FieldAttr(nst: 152)] public float _knockawayAngleMin;
        [FieldAttr(nst: 156)] public float _knockawayAngleMax;
        [FieldAttr(nst: 160)] public float _bonusCriticalHitChance;
        [FieldAttr(nst: 168)] public CTakeHitData? _takeHitData;
        [FieldAttr(nst: 176)] public float _freezeFrameDuration;
        [FieldAttr(nst: 180)] public CDamageData.EDamageVibration _vibration = CDamageData.EDamageVibration.eDV_Auto;
        [FieldAttr(nst: 184)] public bool _ignoreImmunity;
        [FieldAttr(nst: 185)] public bool _isRedirected;
        [FieldAttr(nst: 186)] public bool _showVfxOnDeath = true;
    }
}
