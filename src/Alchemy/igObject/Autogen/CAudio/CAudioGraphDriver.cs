namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 64, align: 8)]
    public class CAudioGraphDriver : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CAudioGraphDriverModeList? _modes;
        [FieldAttr(nst: 24, ctr: 24)] public CAudioGraphList? _affectedGraphs;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public CAudioGraphDriverMode? _currentMode;
        [FieldAttr(nst: 40, ctr: 40)] public float _lastInput;
        [FieldAttr(ctr: 44)] public float _minSpeedModifier;
        [FieldAttr(ctr: 48)] public float _currentPitchValue;
        [FieldAttr(ctr: 52)] public float _originalPitchValue;
        [FieldAttr(ctr: 56)] public float _wantedPitchValue;
    }
}
