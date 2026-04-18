namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 8)]
    public class CChannelGroup : igObject
    {
        [ObjectAttr(size: 4)]
        public class ComputeLoudness : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _computeLoudnessOnDurango;
            [FieldAttr(offset: 1, size: 1)] public bool _computeLoudnessOnPS4;
            [FieldAttr(offset: 2, size: 1)] public bool _computeLoudnessOnWindows;
        }

        [FieldAttr(nst: 16, ctr: 16)] public string? _name = "NOT_SET";
        [FieldAttr(nst: 24, ctr: 24)] public u8 _defaultVolume = 255;
        [FieldAttr(nst: 25, ctr: 25)] public u8 _defaultPitch = 127;
        [FieldAttr(nst: 32, ctr: 32)] public CChannelGroupList? _grpList;
        [FieldAttr(nst: 40, ctr: 40)] public CDspList? _dspList;
        [FieldAttr(nst: 48, ctr: 48)] public bool _mute;
        [FieldAttr(nst: 49, ctr: 49)] public bool _solo;
        [FieldAttr(nst: 52, ctr: 52)] public ComputeLoudness _computeLoudness = new();
        [FieldAttr(nst: 56, ctr: 56)] public igRawRefMetaField _channelGroup = new();
        [FieldAttr(nst: 64, ctr: 64)] public igRawRefMetaField _loudnessDsp = new();
        [FieldAttr(nst: 72, ctr: 72)] public float[] _volumeArray = new float[7];
        [FieldAttr(nst: 100, ctr: 100)] public float[] _pitchArray = new float[7];
        [FieldAttr(nst: 128, ctr: 128)] public float _computedLoudness;
        [FieldAttr(nst: 136, ctr: 136)] public igHandleMetaField _parent = new();
    }
}
