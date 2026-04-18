namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class JuiceFloatKeyframe : JuiceKeyframe
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _value;
        [FieldAttr(nst: 28, ctr: 20)] public bool _dynamic;
    }
}
