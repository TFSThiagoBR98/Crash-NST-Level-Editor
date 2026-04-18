namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4)]
    public class COctaneHubProgressionValues : igObject
    {
        [FieldAttr(ctr: 12)] public int _trophyValue;
        [FieldAttr(ctr: 16)] public int _ctrTokenValue;
        [FieldAttr(ctr: 20)] public int _gemValue;
        [FieldAttr(ctr: 24)] public int _relicValue;
        [FieldAttr(ctr: 28)] public int _bossKeyValue;
        [FieldAttr(ctr: 32)] public int _oxideChallenge;
        [FieldAttr(ctr: 36)] public int _oxideFinalChallenge;
        [FieldAttr(ctr: 40)] public int _allGoldPlatinumRelic;
        [FieldAttr(ctr: 44)] public int _maxRelicCount;
    }
}
