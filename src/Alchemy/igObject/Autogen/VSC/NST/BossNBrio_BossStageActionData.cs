namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_BossStageActionData : CVscComponentData
    {
        public enum EBossStageActionType
        {
            PotionThrowGreen = 0,
            PotionThrowPurple = 1,
            HulkTransform = 2,
        }

        [FieldAttr(nst: 40)] public EBossStageActionType _BossStageActionType;
        [FieldAttr(nst: 44)] public float _DelayStart;
        [FieldAttr(nst: 48)] public float _PotionThrowGreenPlayerDistanceInfluenceRatio;
        [FieldAttr(nst: 56)] public igHandleMetaField _GreenPotionThrowTargetWaypt = new();
    }
}
