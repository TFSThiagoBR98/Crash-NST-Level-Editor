namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CGuiMovieSpriteDrawCallModifier : igSpriteDrawCallModifier
    {
        [FieldAttr(ctr: 16)] public CStreamingMovie? _movie;
    }
}
