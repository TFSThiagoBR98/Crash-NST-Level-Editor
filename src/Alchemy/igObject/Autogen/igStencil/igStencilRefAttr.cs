namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class igStencilRefAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24)] public uint _refVal;
    }
}
