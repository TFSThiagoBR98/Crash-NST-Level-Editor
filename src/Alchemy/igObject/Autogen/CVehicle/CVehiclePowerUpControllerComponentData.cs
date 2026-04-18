namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CVehiclePowerUpControllerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _debug;
        [FieldAttr(ctr: 20)] public float _minimumAnimationLength;
        [FieldAttr(ctr: 24)] public float _maximumAnimationLength;
        [FieldAttr(ctr: 28)] public float _throwForwardThreshold;
        [FieldAttr(ctr: 32)] public float _throwBackwardThreshold;
    }
}
