namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGuiFieldTrack : igGuiTrack
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igMetaFieldInstance? _targetField;
        [FieldAttr(nst: 32, ctr: 32)] public int _fieldOffset;
        [FieldAttr(nst: 36, ctr: 36)] public igGuiKeyframe.EInterpolationMode _interpolation = igGuiKeyframe.EInterpolationMode.kInterpolationLinear;
        [FieldAttr(nst: 40, ctr: 40)] public bool _offsetMode;
    }
}
