namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 224, align: 8)]
    public class CGameSoundSystemDataConfig : CSoundSystemDataConfig
    {
        [FieldAttr(nst: 152, ctr: 140)] public float _binkVolumeDurango = 1.0f;
        [FieldAttr(nst: 156, ctr: 144)] public float _binkVolumePs4 = 1.0f;
        [FieldAttr(nst: 160, ctr: 148)] public float _binkVolumeWiiU = 1.0f;
        [FieldAttr(nst: 164, ctr: 152)] public float _binkVolumeWindows = 1.0f;
        [FieldAttr(nst: 168, ctr: 160)] public CAudioBinkSettingsList? _audioBinkSettingsList;
        [FieldAttr(nst: 176, ctr: 168)] public float _traversalTrack1Volume = 1.0f;
        [FieldAttr(nst: 180, ctr: 172)] public float _traversalAccelerationSmoothing = 97.0f;
        [FieldAttr(nst: 184, ctr: 176)] public float _traversalDecelerationSmoothing = 99.59999847f;
        [FieldAttr(nst: 188, ctr: 180)] public float _traversalZeroVolumeSpeed = 100.0f;
        [FieldAttr(nst: 192, ctr: 184)] public float _traversalFullVolumeSpeed = 200.0f;
        [FieldAttr(nst: 196, ctr: 188)] public float traversalMaxSpeed = 210.0f;
        [FieldAttr(nst: 200, ctr: 192)] public float _windGustThreshold = 0.3f;
        [FieldAttr(nst: 208, ctr: 200)] public igStringRefList? _queuePrefixes;
        [FieldAttr(nst: 216, ctr: 208)] public float _splitscreenAudioAttenuationFactor = 0.5f;
        [FieldAttr(nst: 224, ctr: 216)] public CGameSoundClassList? _soundClassList;
    }
}
