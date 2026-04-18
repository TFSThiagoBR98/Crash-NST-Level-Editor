namespace Alchemy
{
    [ObjectAttr(nst: 216, ctr: 216, align: 8)]
    public class CSoundInstance : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igRawRefMetaField _channel = new();
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _sound = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _nextSound = new();
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _subSound = new();
        [FieldAttr(nst: 56, ctr: 56)] public float _defaultFrequency;
        [FieldAttr(nst: 60, ctr: 60)] public float _rawPcmVolume;
        [FieldAttr(nst: 64, ctr: 64)] public igTimeMetaField _firstTryPlayTime = new();
        [FieldAttr(nst: 68, ctr: 68)] public igTimeMetaField _soundBufferStartTime = new();
        [FieldAttr(nst: 72, ctr: 72)] public float _soundBufferDuration;
        [FieldAttr(nst: 76, ctr: 76)] public igTimeMetaField _startEdcTime = new();
        [FieldAttr(nst: 80, ctr: 80)] public igRawRefMetaField _dsp = new();
        [FieldAttr(nst: 88, ctr: 88)] public float _dspCallbackOutput;
        [FieldAttr(nst: 92, ctr: 92)] public float _distanceToFocus;
        [FieldAttr(nst: 96, ctr: 96)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 108, ctr: 108)] public igVec3fMetaField _forward = new();
        [FieldAttr(nst: 120, ctr: 120)] public bool _loading;
        [FieldAttr(nst: 121, ctr: 121)] public bool _paused;
        [FieldAttr(nst: 122, ctr: 122)] public bool _positionUpdatedExternally;
        [FieldAttr(nst: 123, ctr: 123)] public bool _hasBeenUnpaused;
        [FieldAttr(nst: 124, ctr: 124)] public bool _isDelayed;
        [FieldAttr(nst: 128, ctr: 128)] public uint _length;
        [FieldAttr(nst: 132, ctr: 132)] public float _initialVolume = 1.0f;
        [FieldAttr(nst: 136, ctr: 136)] public float _fadeVolume = 1.0f;
        [FieldAttr(nst: 140, ctr: 140)] public float _duckingVolume = 1.0f;
        [FieldAttr(nst: 144, ctr: 144)] public float _attenuation3dVolume = 1.0f;
        [FieldAttr(nst: 148, ctr: 148)] public float _initialRandomness;
        [FieldAttr(nst: 152, ctr: 152)] public float _basePitch = 1.0f;
        [FieldAttr(nst: 160, ctr: 160)] public igHandleMetaField _dspOverrideSet = new();
        [FieldAttr(nst: 168, ctr: 168)] public igPitchOverrideList? _pitchOverrides;
        [FieldAttr(nst: 176, ctr: 176)] public CSoundInstanceHandleList? _additionalSoundInstances;
        [FieldAttr(nst: 184, ctr: 184)] public igVscDelegateMetaField _stopDelegate = new();
        [FieldAttr(nst: 200, ctr: 200)] public COnSoundInstanceStopEventList? _onStopEventList;
        [FieldAttr(nst: 208, ctr: 208)] public igSoundUpdateMethodList? _dynamicUpdateData;
    }
}
