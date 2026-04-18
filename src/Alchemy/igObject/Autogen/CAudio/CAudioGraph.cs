namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CAudioGraph : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _minUsablePercent;
        [FieldAttr(nst: 20, ctr: 16)] public float _maxUsablePercent = 100.0f;
        [FieldAttr(nst: 24, ctr: 24)] public CAudioGraphModuleList? _modules;
        [FieldAttr(nst: 32, ctr: 32)] public float _maxInputPercentIncreasePerFrame = 100.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _maxInputPercentDecreasePerFrame = 100.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _currentPercent;
        [FieldAttr(nst: 44, ctr: 44)] public bool _enableModules = true;
        [FieldAttr(nst: 48, ctr: 48)] public int _graphID = -1;
        [FieldAttr(nst: 52, ctr: 52)] public float _testInputPercent;
        [FieldAttr(nst: 56, ctr: 56)] public bool _useTestInputPercent;
    }
}
