namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igShaderParametersAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public int _unitID = -1;
        [FieldAttr(nst: 32, ctr: 24)] public igShaderConstantDataList? _dataList;
    }
}
