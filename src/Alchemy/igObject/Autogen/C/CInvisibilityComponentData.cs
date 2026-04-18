namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CInvisibilityComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CEntity? _invisibilityData;
        [FieldAttr(ctr: 32)] public CEntity? _juicedInvisibilityData;
    }
}
