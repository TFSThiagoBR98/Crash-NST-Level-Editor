namespace Alchemy
{
    [ObjectAttr(nst: 136, ctr: 128, align: 8)]
    public class CVfxDrawVisualDataOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 24)] public CVisualDataGroup? _visualData;
        [FieldAttr(nst: 40, ctr: 32)] public igVfxRangedCurveMetaField _influence = new();
        [FieldAttr(nst: 124, ctr: 116)] public EOperatorCurveInput _influenceInput;
        [FieldAttr(nst: 128, ctr: 120)] public uint _instanceData;
    }
}
