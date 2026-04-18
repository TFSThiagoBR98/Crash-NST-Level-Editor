namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CTurboBoostComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CKartBoostData? _boostData;
        [FieldAttr(ctr: 32)] public CKartBoostData? _juicedBoostData;
        [FieldAttr(ctr: 40)] public CEntity? _turboData;
    }
}
