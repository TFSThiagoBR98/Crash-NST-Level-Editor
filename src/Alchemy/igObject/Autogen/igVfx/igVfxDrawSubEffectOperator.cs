namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 48, align: 8)]
    public class igVfxDrawSubEffectOperator : igVfxDrawOperator
    {
        public enum ESubEffectSecondBolt
        {
            kBoltNone = 0,
            kBolt1Follow = 1,
            kBolt1Position = 2,
            kSpawnPosition = 3,
            kBolt2Follow = 4,
            kBolt2Position = 5,
        }

        public enum ESubEffectChildKill
        {
            kDontKill = 0,
            kSoftKill = 1,
            kHardKill = 2,
        }

        public enum ESubEffectChainMode
        {
            kChainNone = 0,
            kChainTail = 1,
            kChainHead = 2,
        }

        public enum ESubEffectChainOrientationMode
        {
            kChainOrientationForward = 0,
            kChainOrientationReverse = 1,
            kChainOrientationAlternate = 2,
            kChainOrientationRandom = 3,
        }

        [ObjectAttr(size: 2)]
        public class SubEffectFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public igVfxDrawSubEffectOperator.ESubEffectSecondBolt _secondBolt;
            [FieldAttr(offset: 3, size: 2)] public igVfxDrawSubEffectOperator.ESubEffectChildKill _childKill;
            [FieldAttr(offset: 5, size: 2)] public igVfxDrawSubEffectOperator.ESubEffectChainMode _chain;
            [FieldAttr(offset: 7, size: 2)] public igVfxDrawSubEffectOperator.ESubEffectChainOrientationMode _chainOrientation;
            [FieldAttr(offset: 9, size: 1)] public bool _floatingChain;
        }

        [FieldAttr(nst: 32, ctr: 18)] public SubEffectFlags _subEffectFlags = new();
        [FieldAttr(nst: 36, ctr: 20)] public uint _instanceData;
        [FieldAttr(nst: 40, ctr: 24)] public uint _primitiveData;
        [FieldAttr(nst: 48, ctr: 32)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 56, ctr: 40)] public igRangedFloatMetaField _chainLength = new();
    }
}
