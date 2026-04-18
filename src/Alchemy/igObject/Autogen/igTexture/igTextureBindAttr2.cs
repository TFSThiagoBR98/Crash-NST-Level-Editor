namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igTextureBindAttr2 : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 24)] public igTextureAttr2? _texture;
        [FieldAttr(nst: 32, ctr: 32)] public int _unitID = -1;
    }
}
