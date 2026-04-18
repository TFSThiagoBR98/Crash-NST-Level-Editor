namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CDsp : igObject
    {
        [ObjectAttr(size: 4)]
        public class PlatformEnabled : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _enabledOnAspen;
            [FieldAttr(offset: 1, size: 1)] public bool _enabledOnAspenLow;
            [FieldAttr(offset: 2, size: 1)] public bool _enabledOnDurango;
            [FieldAttr(offset: 3, size: 1)] public bool _enabledOnPS4;
            [FieldAttr(offset: 4, size: 1)] public bool _enabledOnWindows;
            [FieldAttr(offset: 5, size: 1)] public bool _unknown;
        }

        [FieldAttr(nst: 16, ctr: 12)] public EigDspType _type;
        [FieldAttr(nst: 24, ctr: 16)] public igRawRefMetaField _dsp = new();
        [FieldAttr(nst: 32, ctr: 24)] public PlatformEnabled _platformEnabled = new();
        [FieldAttr(nst: 36, ctr: 28)] public bool _bypass;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _override = new();
    }
}
