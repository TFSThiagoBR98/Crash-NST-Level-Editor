namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igGuiVec2LinearKeyframe : igGuiFieldKeyframe
    {
        [FieldAttr(ctr: 24)] public igVec2fMetaField _data = new();
    }
}
