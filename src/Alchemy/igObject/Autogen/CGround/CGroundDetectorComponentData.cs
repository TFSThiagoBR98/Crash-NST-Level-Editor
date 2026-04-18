namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class CGroundDetectorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public uint _unsupportedFrames = 5;
        [FieldAttr(nst: 28)] public uint _unsupportedFramesWhileMovingUp = 2;
        [FieldAttr(nst: 32)] public float _upwardVelocityThreshold = 100.0f;
    }
}
