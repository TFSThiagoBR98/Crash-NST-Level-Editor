namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igGuiVec3LinearKeyframe : igGuiFieldKeyframe
    {
        [FieldAttr(ctr: 24)] public igVec3fMetaField _data = new();
    }
}
