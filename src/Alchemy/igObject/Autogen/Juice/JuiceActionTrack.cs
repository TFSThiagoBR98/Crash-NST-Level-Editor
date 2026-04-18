namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class JuiceActionTrack : JuiceTrack
    {
        [FieldAttr(nst: 40, ctr: 40)] public bool _initialized;
        [FieldAttr(nst: 44, ctr: 44)] public float _lastTime;
    }
}
