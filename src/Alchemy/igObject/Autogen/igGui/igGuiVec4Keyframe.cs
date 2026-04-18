namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 16)]
    public class igGuiVec4Keyframe : igGuiFieldKeyframe
    {
        [FieldAttr(nst: 32)] public float _handleInTime;
        [FieldAttr(nst: 36)] public float _handleOutTime;
        [FieldAttr(nst: 48)] public igVec4fMetaField _data = new();
        [FieldAttr(nst: 64)] public igVec4fMetaField _handleInData = new();
        [FieldAttr(nst: 80)] public igVec4fMetaField _handleOutData = new();
    }
}
