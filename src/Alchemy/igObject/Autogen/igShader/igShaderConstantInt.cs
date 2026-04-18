namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igShaderConstantInt : igShaderConstantData
    {
        [FieldAttr(nst: 32)] public int _data;
    }
}
