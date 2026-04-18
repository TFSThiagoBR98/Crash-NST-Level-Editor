namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igTechniqueParameter : igObject
    {
        public enum EPARAMETER_TYPE
        {
            PARAMETER_TYPE_MATRIX = 0,
            PARAMETER_TYPE_VECTOR = 1,
            PARAMETER_TYPE_INTEGER = 2,
            PARAMETER_TYPE_BOOL = 3,
            PARAMETER_TYPE_BOOL_ARRAY = 4,
            PARAMETER_TYPE_VECTORI = 5,
            PARAMETER_TYPE_MATRIX_ARRAY = 6,
            PARAMETER_TYPE_VECTOR_ARRAY = 7,
            PARAMETER_TYPE_INTEGER_ARRAY = 8,
            PARAMETER_TYPE_VECTORI_ARRAY = 9,
            PARAMETER_TYPE_FLOAT = 10,
            PARAMETER_TYPE_FLOAT_ARRAY = 11,
            PARAMETER_TYPE_UNKNOWN = 65535,
        }

        [FieldAttr(nst: 16)] public string? _shaderName = null;
        [FieldAttr(nst: 24)] public string? _engineName = null;
        [FieldAttr(nst: 32)] public bool _isEngine;
        [FieldAttr(nst: 36)] public EPARAMETER_TYPE _type = igTechniqueParameter.EPARAMETER_TYPE.PARAMETER_TYPE_UNKNOWN;
        [FieldAttr(nst: 40)] public int _vectorWidth = 4;
        [FieldAttr(nst: 44)] public int _elementIndex;
        [FieldAttr(nst: 48)] public int _elementSize = 1;
        [FieldAttr(nst: 52)] public int _elementCount = 1;
    }
}
