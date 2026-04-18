namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_LoopSoundAcrossAnimationsData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _RestartSoundUponAnimationChange;
        [FieldAttr(nst: 48)] public igHandleMetaField _LoopingSound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AttackSound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Animations = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
    }
}
