namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CPlatformAudioSettingsOverride : igObject
    {
        [FieldAttr(ctr: 12)] public EIG_CORE_PLATFORM _platform;
        [FieldAttr(ctr: 16)] public int _sampleRate;
        [FieldAttr(ctr: 20)] public int _quality;
    }
}
