namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class igVfxSpawnRateData : igObject
    {
        public enum ETimeInput
        {
            kPrimitiveTime = 0,
            kZeroTime = 1,
            kBolt1Input1 = 2,
            kBolt1Input2 = 3,
            kBolt1Input3 = 4,
            kBolt1Input4 = 5,
            kBolt2Input1 = 6,
            kBolt2Input2 = 7,
            kBolt2Input3 = 8,
            kBolt2Input4 = 9,
        }

        [FieldAttr(nst: 16, ctr: 12)] public int _maxCount;
        [FieldAttr(nst: 20, ctr: 16)] public int _minCount = 1;
        [FieldAttr(nst: 24, ctr: 20)] public bool _sputter;
        [FieldAttr(nst: 25, ctr: 21)] public bool _killOldest;
        [FieldAttr(nst: 28, ctr: 24)] public ETimeInput _timeInput;
    }
}
