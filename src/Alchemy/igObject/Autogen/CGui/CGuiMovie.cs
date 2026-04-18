namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class CGuiMovie : igGuiSprite
    {
        [FieldAttr(ctr: 64)] public string? _url;
        [FieldAttr(ctr: 72)] public CGuiMovieSpriteDrawCallModifier? _drawCallModifier;
    }
}
