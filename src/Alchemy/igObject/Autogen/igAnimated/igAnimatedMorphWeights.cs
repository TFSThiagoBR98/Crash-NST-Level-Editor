namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igAnimatedMorphWeights : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<float> _data = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<float> _times = new();
        [FieldAttr(nst: 64, ctr: 64)] public int _targetCount;
        [FieldAttr(nst: 68, ctr: 68)] public float _duration = -1.0f;
        [FieldAttr(nst: 72, ctr: 72)] public float _keyframeTimeOffset;
        [FieldAttr(nst: 76, ctr: 76)] public EIG_UTILS_PLAY_MODE _playMode;
    }
}
