namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class igGuiVec2Keyframe : igGuiFieldKeyframe
    {
        [FieldAttr(nst: 32)] public float _handleInTime;
        [FieldAttr(nst: 36)] public float _handleOutTime;
        [FieldAttr(nst: 40)] public igVec2fMetaField _data = new();
        [FieldAttr(nst: 48)] public igVec2fMetaField _handleInData = new();
        [FieldAttr(nst: 56)] public igVec2fMetaField _handleOutData = new();
    }
}
