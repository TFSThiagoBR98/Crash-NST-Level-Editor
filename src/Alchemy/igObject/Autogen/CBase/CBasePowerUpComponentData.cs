namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CBasePowerUpComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _powerUpName;
    }
}
