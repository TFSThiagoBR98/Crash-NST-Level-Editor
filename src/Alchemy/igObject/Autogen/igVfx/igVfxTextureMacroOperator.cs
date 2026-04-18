namespace Alchemy
{
    [ObjectAttr(nst: 216, align: 4)]
    public class igVfxTextureMacroOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
            [FieldAttr(offset: 2, size: 4)] public EReferenceFrame _frame = EReferenceFrame.eRF_World;
        }

        [FieldAttr(nst: 24)] public Flags _flags = new();
        [FieldAttr(nst: 28)] public igVec2fMetaField _pivot = new();
        [FieldAttr(nst: 36)] public igVfxRangedCurveMetaField _scaleX = new();
        [FieldAttr(nst: 120)] public igVfxRangedCurveMetaField _scaleY = new();
        [FieldAttr(nst: 204)] public EOperatorCurveInput _scaleInput;
        [FieldAttr(nst: 208)] public EigVfxCurveCorrelation _scaleCorrelation;
    }
}
