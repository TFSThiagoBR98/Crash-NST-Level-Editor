namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CAudioGraphDriverModeSurfaceBoostStage : igObject
    {
        [FieldAttr(ctr: 12)] public float _duration;
        [FieldAttr(ctr: 16)] public float _startGraphInput;
        [FieldAttr(ctr: 20)] public float _endGraphInput;
        [FieldAttr(ctr: 24)] public igHandleMetaField _activationOneShotSound = new();
    }
}
