namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igTimer : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _active;
        [FieldAttr(nst: 20, ctr: 16)] public igTimeMetaField _startTime = new();
        [FieldAttr(nst: 24, ctr: 20)] public float _elapsedSeconds;
    }
}
