namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CBossPowerUpRubberbandData : igObject
    {
        [FieldAttr(ctr: 12)] public float _maxRubberbandRatio;
        [FieldAttr(ctr: 16)] public CPowerUpWeightHashTable? _powerUpWeights;
        [FieldAttr(ctr: 24)] public CDifficultySpecificPowerUpWeightHashTable? _difficultySpecificPowerUpWeights;
    }
}
