namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGlobalKartData : igObject
    {
        [FieldAttr(ctr: 16)] public CKartInputData? _buttonInputs;
        [FieldAttr(ctr: 24)] public CKartAirTimeBoostDataList? _airTimeBoostData;
        [FieldAttr(ctr: 32)] public float _maxAirTimeDuration;
        [FieldAttr(ctr: 36)] public int _wumpaFruitsLostOnRespawn;
        [FieldAttr(ctr: 40)] public float _juicedUpMaxSpeedModifier;
        [FieldAttr(ctr: 44)] public float _wumpaFruitStartCollectDelay;
        [FieldAttr(ctr: 48)] public float _wumpaFruitTickDelay;
        [FieldAttr(ctr: 52)] public float _allTimeCrateCollectedBonus;
        [FieldAttr(ctr: 56)] public CKartCollisionMaterialBoostDataList? _collisionMaterialBoostData;
        [FieldAttr(ctr: 64)] public CKartCollisionMaterialSlipperyDataList? _collisionMaterialSlipperyData;
    }
}
