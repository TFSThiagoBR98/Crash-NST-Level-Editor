namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class ActorInput : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public ActorInputCommand? _input;
        [FieldAttr(nst: 24, ctr: 24)] public float _delta;
        [FieldAttr(nst: 28, ctr: 28)] public float _deltaScaled;
        [FieldAttr(nst: 32, ctr: 32)] public i64 _previousButtonStates;
        [FieldAttr(nst: 40, ctr: 40)] public CTimer? _touchDuration;
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _lastPressedDirection = new();
        [FieldAttr(nst: 60, ctr: 60)] public float _stickSpeedWithDeadzone;
        [FieldAttr(nst: 64, ctr: 64)] public bool _inputProcessed;
        [FieldAttr(nst: 72, ctr: 72)] public COnProcessInputEventList? _onProcessInputEventList;
        [FieldAttr(nst: 80, ctr: 80)] public COnProcessInputDelegate? _onProcessInput;
        [FieldAttr(nst: 88, ctr: 88)] public CEnableRequestManager? _lockControls;
    }
}
