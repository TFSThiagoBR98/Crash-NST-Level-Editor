namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 200, align: 8)]
    public class CVfxDrawForceFeedbackOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _rumbleMagnitude = new();
        [FieldAttr(nst: 116, ctr: 104)] public igVfxRangedCurveMetaField _vibrationMagnitude = new();
        [FieldAttr(nst: 200, ctr: 188)] public EOperatorCurveInput _rumbleInput;
        [FieldAttr(nst: 204, ctr: 192)] public bool _playerOne;
        [FieldAttr(nst: 205, ctr: 193)] public bool _playerTwo;
        [FieldAttr(nst: 206, ctr: 194)] public bool _currentPlayer = true;
    }
}
