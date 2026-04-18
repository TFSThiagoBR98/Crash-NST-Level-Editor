namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 112, align: 16)]
    public class igAnimatedTransformSource : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _dataStride;
        [FieldAttr(nst: 32, ctr: 16)] public igVectorMetaField<float> _data = new();
        [FieldAttr(nst: 56, ctr: 40)] public igVectorMetaField<float> _times = new();
        [FieldAttr(nst: 80, ctr: 64)] public float _duration = 259200.0f;
        [FieldAttr(nst: 84, ctr: 68)] public float _keyframeTimeOffset;
        [FieldAttr(nst: 88, ctr: 72)] public uint _componentChannels;
        [FieldAttr(nst: 92, ctr: 76)] public u8[] _channelOffsets = new u8[3];
        [FieldAttr(nst: 95, ctr: 79)] public u8[] _interpolationMethod = new u8[3];
        [FieldAttr(nst: 100, ctr: 84)] public EIG_UTILS_PLAY_MODE _playMode;
        [FieldAttr(nst: 112, ctr: 96)] public igVec4fMetaField _centerOfRotation = new();
    }
}
