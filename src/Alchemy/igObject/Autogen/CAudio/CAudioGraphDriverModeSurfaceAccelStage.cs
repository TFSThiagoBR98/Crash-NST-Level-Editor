namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CAudioGraphDriverModeSurfaceAccelStage : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _duration;
        [FieldAttr(nst: 20, ctr: 16)] public float _startGraphInput;
        [FieldAttr(nst: 24, ctr: 20)] public float _endGraphInput;
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _activationOneShotSound = new();
    }
}
