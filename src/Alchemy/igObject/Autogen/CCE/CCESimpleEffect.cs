namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8)]
    public class CCESimpleEffect : CCombatNodeEvent
    {
        public enum EKillOnEndMode
        {
            eKOEM_None = 0,
            eKOEM_SoftKill = 1,
            eKOEM_HardKill = 2,
        }

        [FieldAttr(nst: 80)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 88)] public bool _attemptFireAndForget = true;
        [FieldAttr(nst: 89)] public bool _preventDuplicates;
        [FieldAttr(nst: 96)] public CBoltPoint? _boltPoint1;
        [FieldAttr(nst: 104)] public CBoltPoint? _boltPoint2;
        [FieldAttr(nst: 112)] public EKillOnEndMode _killOnEndMode;
    }
}
