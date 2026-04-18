namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igGuiVec3Keyframe : igGuiFieldKeyframe
    {
        [FieldAttr(nst: 32, ctr: 24)] public float _handleInTime;
        [FieldAttr(nst: 36, ctr: 28)] public float _handleOutTime;
        [FieldAttr(nst: 40, ctr: 32)] public igVec3fMetaField _data = new();
        [FieldAttr(nst: 52, ctr: 44)] public igVec3fMetaField _handleInData = new();
        [FieldAttr(nst: 64, ctr: 56)] public igVec3fMetaField _handleOutData = new();
    }
}
