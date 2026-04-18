namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igShaderConstantData : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public int _handle = -1;
    }
}
