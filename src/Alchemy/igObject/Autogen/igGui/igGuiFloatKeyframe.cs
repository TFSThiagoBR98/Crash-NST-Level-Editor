namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class igGuiFloatKeyframe : igGuiFieldKeyframe
    {
        [FieldAttr(nst: 32, ctr: 24)] public float _handleInTime;
        [FieldAttr(nst: 36, ctr: 28)] public float _handleOutTime;
        [FieldAttr(nst: 40, ctr: 32)] public float _data;
        [FieldAttr(nst: 44, ctr: 36)] public float _handleInData;
        [FieldAttr(nst: 48, ctr: 40)] public float _handleOutData;
    }
}
