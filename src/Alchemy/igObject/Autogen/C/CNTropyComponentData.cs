namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CNTropyComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CEntity? _nTropyData;
        [FieldAttr(ctr: 32)] public CEntity? _juicedNtropyData;
    }
}
