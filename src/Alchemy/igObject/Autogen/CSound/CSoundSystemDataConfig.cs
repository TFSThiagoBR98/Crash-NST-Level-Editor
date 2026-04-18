namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 144, align: 8)]
    public class CSoundSystemDataConfig : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _duckingMaxRateOfChange = 0.2f;
        [FieldAttr(nst: 20, ctr: 16)] public float _duckingMaxChange = 0.4f;
        [FieldAttr(nst: 24, ctr: 20)] public float _duckingIdealAsymptoticApproach = 0.666f;
        [FieldAttr(nst: 28, ctr: 24)] public float _soundSpread = 70.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _stereoSoundSpread = 180.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _minSpatializationRadius = 60.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _maxSpatializationRadius = 120.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _ellipticalListenerInterpolationWideFactor = 2.0f;
        [FieldAttr(nst: 48, ctr: 44)] public float _angularAttenuationInnerAngle = 22.5f;
        [FieldAttr(nst: 52, ctr: 48)] public float _angularAttenuationOuterAngle = 90.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _angularAttenuation = 1.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _loudnessFactor = 1.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _soundRangeShutoffScale = 1.5f;
        [FieldAttr(nst: 68, ctr: 64)] public float _pauseFadeIn = 0.2f;
        [FieldAttr(nst: 72, ctr: 68)] public float _dspOverrideFade = 2.0f;
        [FieldAttr(nst: 80, ctr: 72)] public CAudioArchiveList? _permanentAudioBanks;
        [FieldAttr(nst: 88, ctr: 80)] public int _channelCount = 128;
        [FieldAttr(nst: 92, ctr: 84)] public int _defaultAudioArchiveCount = 32;
        [FieldAttr(nst: 96, ctr: 88)] public int _specificAudioArchiveCount = 128;
        [FieldAttr(nst: 100, ctr: 92)] public int _soundInstanceCount = 128;
        [FieldAttr(nst: 104, ctr: 96)] public int _channelGroupCount = 128;
        [FieldAttr(nst: 108, ctr: 100)] public int _soundGroupCount = 128;
        [FieldAttr(nst: 112, ctr: 104)] public EStreamBufferUnits _streamBufferUnits = EStreamBufferUnits.kUnitsMs;
        [FieldAttr(nst: 116, ctr: 108)] public float _streamBufferLengthSeconds = 2.0f;
        [FieldAttr(nst: 120, ctr: 112)] public int _streamBufferLengthKilobytes = 146;
        [FieldAttr(nst: 124, ctr: 116)] public int _streamDecodeBufferLength;
        [FieldAttr(nst: 128, ctr: 120)] public float _minEdcSyncPitch = 0.97f;
        [FieldAttr(nst: 132, ctr: 124)] public float _maxEdcSyncPitch = 1.02999997f;
        [FieldAttr(nst: 136, ctr: 128)] public float _edcSyncSmoothTime = 2.0f;
        [FieldAttr(nst: 140, ctr: 132)] public int _maxTotalStreamedSounds = 6;
        [FieldAttr(nst: 144, ctr: 136)] public int _maxBufferingOrPlayingStreamedSounds = 3;
    }
}
