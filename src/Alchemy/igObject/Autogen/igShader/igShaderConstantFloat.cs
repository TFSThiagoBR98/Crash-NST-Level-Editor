namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igShaderConstantFloat : igShaderConstantData
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _data;
    }
}
