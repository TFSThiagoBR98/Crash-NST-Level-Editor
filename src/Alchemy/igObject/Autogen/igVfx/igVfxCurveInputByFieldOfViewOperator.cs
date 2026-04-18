namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class igVfxCurveInputByFieldOfViewOperator : igVfxFrameOperator
    {
        public enum EFieldOfViewInput
        {
            kHorizontalFOV = 0,
            kHorizontalTanFOV = 1,
            kVerticalFOV = 2,
            kVerticalTanFOV = 3,
        }

        [FieldAttr(nst: 32)] public EFieldOfViewInput _fovInput;
        [FieldAttr(nst: 36)] public EOperatorCurveOutput _outputParameter = EOperatorCurveOutput.kSetTrackParameter1;
    }
}
