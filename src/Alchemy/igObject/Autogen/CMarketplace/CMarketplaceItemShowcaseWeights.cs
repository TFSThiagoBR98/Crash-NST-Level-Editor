namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CMarketplaceItemShowcaseWeights : igObject
    {
        [FieldAttr(ctr: 16)] public CMarketplaceTierWeightTable? _tierWeights;
        [FieldAttr(ctr: 24)] public CMarketplaceTimeWeightList? _timeWeights;
        [FieldAttr(ctr: 32)] public float _alreadySeenWeightMultiplier;
    }
}
