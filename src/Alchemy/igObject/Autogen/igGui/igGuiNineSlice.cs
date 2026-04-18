namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 16)]
    public class igGuiNineSlice : igGuiSprite
    {
        [FieldAttr(nst: 64, ctr: 60)] public float _leftSize;
        [FieldAttr(nst: 68, ctr: 64)] public float _rightSize;
        [FieldAttr(nst: 72, ctr: 68)] public float _topSize;
        [FieldAttr(nst: 76, ctr: 72)] public float _bottomSize;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igSprite? _topLeftSprite;
        [FieldAttr(nst: 88, ctr: 88, refCount: false)] public igSprite? _topSprite;
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igSprite? _topRightSprite;
        [FieldAttr(nst: 104, ctr: 104, refCount: false)] public igSprite? _leftSprite;
        [FieldAttr(nst: 112, ctr: 112, refCount: false)] public igSprite? _rightSprite;
        [FieldAttr(nst: 120, ctr: 120, refCount: false)] public igSprite? _bottomLeftSprite;
        [FieldAttr(nst: 128, ctr: 128, refCount: false)] public igSprite? _bottomSprite;
        [FieldAttr(nst: 136, ctr: 136, refCount: false)] public igSprite? _bottomRightSprite;
    }
}
