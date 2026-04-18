namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igGuiKeyframe : igObject
    {
        public enum EInterpolationMode
        {
            kInterpolationInheritFromTrack = -1,
            kInterpolationNone = 0,
            kInterpolationLinear = 1,
            kInterpolationBezier = 2,
        }

        [FieldAttr(nst: 16, ctr: 12)] public igTimeMetaField _time = new();
        [FieldAttr(nst: 20, ctr: 16)] public EInterpolationMode _interpolationIn = igGuiKeyframe.EInterpolationMode.kInterpolationInheritFromTrack;
        [FieldAttr(nst: 24, ctr: 20)] public EInterpolationMode _interpolationOut = igGuiKeyframe.EInterpolationMode.kInterpolationInheritFromTrack;
    }
}
