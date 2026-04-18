namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 112, align: 8)]
    public class igVfxCurveInputRemapOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVfxRangedCurveMetaField _mapping = new();
        [FieldAttr(nst: 108, ctr: 100)] public EOperatorCurveInput _inputParameter = EOperatorCurveInput.kTrackParameter1;
        [FieldAttr(nst: 112, ctr: 104)] public EOperatorCurveOutput _outputParameter = EOperatorCurveOutput.kSetTrackParameter1;
    }
}
