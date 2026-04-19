namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8, meta: true)]
    public class CEnableStack : igObject
    {
        public enum EEnableStackMode
        {
            eESM_StartEnabled = 0,
            eESM_StartDisabled = 1,
        }

        [FieldAttr(nst: 16, ctr: 16)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 24, ctr: 24)] public int _stackCounter;
        [FieldAttr(nst: 28, ctr: 28)] public EEnableStackMode _mode;
        [FieldAttr(nst: 32, ctr: 32)] public int _allowNegativeStackRequests;
        [FieldAttr(nst: 36, ctr: 36)] public bool _enableMismatchedCallChecks = true;
        [FieldAttr(nst: 40, ctr: 40)] public string? _enableErrorMessage = "RequestEnable() has been called more times than RequestDisable()";
        [FieldAttr(nst: 48, ctr: 48)] public string? _disableErrorMessage = "RequestDisable() has been called more times than RequestEnable()";
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igMetaObject? _meta;
    }
}
