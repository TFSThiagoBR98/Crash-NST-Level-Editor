namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class JuiceFieldTrack : JuiceFloatKeyframeList
    {
        [FieldAttr(nst: 40, ctr: 40)] public string? _field = null;
        [FieldAttr(nst: 48, ctr: 48)] public bool _interpolationEnabled = true;
        [FieldAttr(nst: 56, ctr: 56)] public JuiceFloatKeyframe? _initialKeyFrame;
        [FieldAttr(nst: 64, ctr: 64)] public bool _initialized;
        [FieldAttr(nst: 68, ctr: 68)] public float _initialValue;
    }
}
