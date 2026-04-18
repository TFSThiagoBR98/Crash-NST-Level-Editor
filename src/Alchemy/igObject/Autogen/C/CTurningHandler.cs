namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 104, align: 8)]
    public class CTurningHandler : CBehaviorLogic
    {
        public enum ETurningInputMethod
        {
            eTIM_Directional = 0,
            eTIM_Additive = 1,
        }

        [FieldAttr(nst: 80, ctr: 64)] public ETurningInputMethod _inputMethod;
        [FieldAttr(nst: 84, ctr: 68)] public bool _canTurnWhileStanding;
        [FieldAttr(nst: 88, ctr: 72)] public EAnalogStick _turningStick;
        [FieldAttr(nst: 92, ctr: 76)] public float _stickThreshhold = 0.1f;
        [FieldAttr(nst: 96, ctr: 80)] public float _maximumTurnRate = 10800.0f;
        [FieldAttr(nst: 100, ctr: 84)] public float _modelTurnRate = 900.0f;
        [FieldAttr(nst: 104, ctr: 88)] public float _priority;
        [FieldAttr(nst: 108, ctr: 92)] public bool _overrideJumpTurning;
        [FieldAttr(nst: 109, ctr: 93)] public bool _turningAxisIsLocalSpace;
        [FieldAttr(nst: 110, ctr: 94)] public bool _leaningEnabled = true;
        [FieldAttr(nst: 112, ctr: 96)] public float _leanAngleRate = 2.5f;
        [FieldAttr(nst: 116, ctr: 100)] public float _leanAngleThreshhold = 10.0f;
    }
}
