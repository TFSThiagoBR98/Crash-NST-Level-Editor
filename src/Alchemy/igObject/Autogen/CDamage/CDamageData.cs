namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 208, align: 8)]
    public class CDamageData : igObject
    {
        public enum EDamageVibration
        {
            eDV_Auto = -2,
            eDV_None = -1,
            eDV_Weakest = 0,
            eDV_Weak = 1,
            eDV_Medium = 2,
            eDV_Strong = 3,
            eDV_Strongest = 4,
            eDV_WeakPain = 5,
            eDV_MediumPain = 6,
            eDV_StrongPain = 7,
        }

        [FieldAttr(nst: 16, ctr: 16)] public CUpgradeableInt? _damageAmountUpgradeable;
        [FieldAttr(nst: 24, ctr: 24)] public int _maxDamageAmount;
        [FieldAttr(nst: 28, ctr: 28)] public uint _damageMods;
        [FieldAttr(nst: 32, ctr: 32)] public EDamageType _damageType = EDamageType.eDMG_Basic;
        [FieldAttr(nst: 36, ctr: 36)] public EAttackType _attackType;
        [FieldAttr(nst: 40, ctr: 40)] public bool _allowFriendlyFire;
        [FieldAttr(nst: 44, ctr: 44)] public float _repeatHitInterval = 3.0f;
        [FieldAttr(nst: 48, ctr: 48)] public string? _immunityGroup = null;
        [FieldAttr(nst: 56, ctr: 56)] public CTakeHitData? _takeHitData;
        [FieldAttr(nst: 64, ctr: 64)] public float _freezeFrameDuration;
        [FieldAttr(nst: 68, ctr: 68)] public EDamageVibration _vibration = CDamageData.EDamageVibration.eDV_Auto;
        [FieldAttr(nst: 72, ctr: 72)] public CCombatNodeEvent? _selfCombatNodeEvent;
        [FieldAttr(nst: 80, ctr: 80)] public CCombatNodeEvent? _victimCombatNodeEvent;
        [FieldAttr(nst: 88, ctr: 88)] public CKnockawayFlightData? _knockawayFlightData;
        [FieldAttr(nst: 96, ctr: 96)] public CKnockawayLandData? _knockawayLandData;
        [FieldAttr(nst: 104, ctr: 104)] public float _knockawayImpulseMin;
        [FieldAttr(nst: 108, ctr: 108)] public float _knockawayImpulseMax;
        [FieldAttr(nst: 112, ctr: 112)] public float _knockawayAngleMin;
        [FieldAttr(nst: 116, ctr: 116)] public float _knockawayAngleMax;
        [FieldAttr(nst: 120, ctr: 120)] public CVehicleKnockawayData? _knockawayVehicles;
        [FieldAttr(nst: 128, ctr: 128)] public CCombatSoundData? _soundData;
        [FieldAttr(nst: 136, ctr: 136)] public igHandleMetaField _hitEffect = new();
        [FieldAttr(nst: 144, ctr: 144)] public igHandleMetaField _hitFlashEffect = new();
        [FieldAttr(nst: 152, ctr: 152)] public bool _ignoreGodMode;
        [FieldAttr(nst: 160, ctr: 160)] public CEntityComponentDataList? _componentsToAttach;
        [FieldAttr(nst: 168, ctr: 168)] public CEntityMessage.ENetworkSendRestriction _componentsToAttachReplication;
        [FieldAttr(nst: 176, ctr: 176)] public CEntityMessage? _victimMessage;
        [FieldAttr(nst: 184, ctr: 184)] public CEntityMessage? _attackerMessage;
        [FieldAttr(nst: 192, ctr: 192)] public igNamedObject? _attackIdentifier;
        [FieldAttr(nst: 200, ctr: 200)] public CUpgradeableFloat? _bonusCriticalHitChance;
    }
}
