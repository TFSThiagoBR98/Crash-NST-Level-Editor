namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CAudioGraphModule : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _sound = new();
        [FieldAttr(nst: 24, ctr: 24)] public float _startPercent;
        [FieldAttr(nst: 28, ctr: 28)] public float _endPercent = 100.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _rootPitchPercent = 50.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _fadeInPercent;
        [FieldAttr(nst: 40, ctr: 40)] public float _fadeOutPercent;
        [FieldAttr(nst: 44, ctr: 44)] public float _fadeInControlPointHeight = 0.69999999f;
        [FieldAttr(nst: 48, ctr: 48)] public float _fadeOutControlPointHeight = 0.69999999f;
        [FieldAttr(nst: 52, ctr: 52)] public bool _changePitch = true;
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _overrideSound = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _playingSound = new();
    }
}
