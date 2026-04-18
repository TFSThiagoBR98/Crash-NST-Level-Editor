namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 16)]
    public class igGuiVec4LinearKeyframe : igGuiFieldKeyframe
    {
        [FieldAttr(ctr: 32)] public igVec4fMetaField _data = new();
    }
}
