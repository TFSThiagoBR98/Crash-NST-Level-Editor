namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 224, align: 8)]
    public class CSound : igObject
    {
        [ObjectAttr(size: 4)]
        public class SoundFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _shouldLoad;
            [FieldAttr(offset: 1, size: 1)] public bool _looping;
            [FieldAttr(offset: 2, size: 3)] public ESoundPauseType _pauseType;
            [FieldAttr(offset: 5, size: 2)] public EPlayBehavior _playBehavior;
            [FieldAttr(offset: 7, size: 2)] public EPlayFeature _playFeature;
            [FieldAttr(offset: 9, size: 1)] public bool _useDuckingGainDirectly;
            [FieldAttr(offset: 10, size: 1)] public bool _duckingInverted;
            [FieldAttr(offset: 11, size: 1)] public bool _canBeDucked;
            [FieldAttr(offset: 12, size: 2)] public ESound3dBehavior _threeDBehavior;
        }

        [ObjectAttr(size: 4)]
        public class RuntimeSoundFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _streaming;
            [FieldAttr(offset: 1, size: 1)] public bool _playingAdditionalSounds;
            [FieldAttr(offset: 2, size: 1)] public bool _initialized;
            [FieldAttr(offset: 3, size: 1)] public bool _isStreamed;
            [FieldAttr(offset: 4, size: 1)] public bool _mute;
            [FieldAttr(offset: 5, size: 1)] public bool _solo;
        }

        [FieldAttr(nst: 16, ctr: 12)] public SoundFlags _soundFlags = new();
        [FieldAttr(nst: 20, ctr: 16)] public RuntimeSoundFlags _runtimeSoundFlags = new();
        [FieldAttr(nst: 24, ctr: 24)] public CSoundInstanceHandleList? _currentlyPlayingSounds;
        [FieldAttr(nst: 32, ctr: 32)] public igTimeMetaField _lastPlayTime = new();
        [FieldAttr(nst: 40, ctr: 40)] public igIntList? _orderToPlayList;
        [FieldAttr(nst: 48, ctr: 48)] public string? _name = "NOT_SET";
        [FieldAttr(nst: 56, ctr: 56)] public float _startTime;
        [FieldAttr(nst: 60, ctr: 60)] public u8 _playPercentage = 100;
        [FieldAttr(nst: 61, ctr: 61)] public u8 _maxPlaybacks = 2;
        [FieldAttr(nst: 62, ctr: 62)] public u8 _priority = 100;
        [FieldAttr(nst: 63, ctr: 63)] public u8 _pitch = 127;
        [FieldAttr(nst: 64, ctr: 64)] public u8 _pitchRandomnessRange = 100;
        [FieldAttr(nst: 65, ctr: 65)] public u8 _duckingGroup = 5;
        [FieldAttr(nst: 68, ctr: 68)] public float _delay;
        [FieldAttr(nst: 72, ctr: 72)] public string? _soundGroupName = "Default_Normal";
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _dspOverrideSet = new();
        [FieldAttr(nst: 88, ctr: 88)] public igSoundUpdateMethodList? _dynamicUpdateData;
        [FieldAttr(nst: 96, ctr: 96)] public CSubSoundList? _subSoundList;
        [FieldAttr(nst: 104, ctr: 104)] public float _volume = 0.5f;
        [FieldAttr(nst: 108, ctr: 108)] public float _volumeRandomnessRange;
        [FieldAttr(nst: 112, ctr: 112)] public float _fadeIn;
        [FieldAttr(nst: 116, ctr: 116)] public float _fadeOut = 0.3f;
        [FieldAttr(nst: 120, ctr: 120)] public string? _channelGroupName = null;
        [FieldAttr(nst: 128, ctr: 128)] public float _duckingAmount;
        [FieldAttr(nst: 132, ctr: 132)] public float _cooldown;
        [FieldAttr(nst: 136, ctr: 136)] public CSoundAttenuateOnUse? _attenuateOnUse;
        [FieldAttr(nst: 144, ctr: 144)] public float _min3d = 300.0f;
        [FieldAttr(nst: 148, ctr: 148)] public float _max3d = 1500.0f;
        [FieldAttr(nst: 152, ctr: 152)] public float _coneInsideAngle = 360.0f;
        [FieldAttr(nst: 156, ctr: 156)] public float _coneOutsideAngle = 360.0f;
        [FieldAttr(nst: 160, ctr: 160)] public float _coneOutsideLevel = 1.0f;
        [FieldAttr(nst: 164, ctr: 164)] public float _delayRandomnessRange;
        [FieldAttr(nst: 168, ctr: 168)] public CSpeakerVolumes? _speakerVolumes;
        [FieldAttr(nst: 176, ctr: 176)] public CSoundHandleOrNameList? _additionalSoundsToPlay;
        [FieldAttr(nst: 184, ctr: 184)] public igHandleMetaField _nextSound = new();
        [FieldAttr(nst: 192, ctr: 192)] public bool _edcSynced;
        [FieldAttr(nst: 193, ctr: 193)] public bool _movieSynced;
        [FieldAttr(nst: 194, ctr: 194)] public bool _trackPCMVolume;
        [FieldAttr(nst: 200, ctr: 200)] public igHandleMetaField _channelGroup = new();
        [FieldAttr(nst: 208, ctr: 208)] public igHandleMetaField _soundGroup = new();
        [FieldAttr(nst: 216, ctr: 216, refCount: false)] public CAudioArchive? _ownerAudioArchive;
    }
}
