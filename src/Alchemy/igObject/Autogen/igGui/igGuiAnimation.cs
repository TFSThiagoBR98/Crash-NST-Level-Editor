namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igGuiAnimation : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igGuiAnimationTag? _tag;
        [FieldAttr(nst: 24, ctr: 24)] public igGuiTrackList? _tracks;
        [FieldAttr(nst: 32, ctr: 32)] public float _length;
    }
}
