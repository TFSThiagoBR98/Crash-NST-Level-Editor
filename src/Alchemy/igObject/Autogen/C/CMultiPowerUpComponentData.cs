namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CMultiPowerUpComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public int _charges;
    }
}
