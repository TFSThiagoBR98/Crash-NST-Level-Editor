namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igShaderConstantValueInt : igShaderConstantValue
    {
        [FieldAttr(nst: 24, ctr: 24)] public int _value;
    }
}
