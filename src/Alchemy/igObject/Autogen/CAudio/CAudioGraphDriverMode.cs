namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CAudioGraphDriverMode : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _activateOneShotSound = new();
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _deactivateOneShotSound = new();
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _whileActiveLoopingSound = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _playingLoopingSound = new();
        [FieldAttr(nst: 48, ctr: 48)] public bool _isAlreadyUsed;
    }
}
