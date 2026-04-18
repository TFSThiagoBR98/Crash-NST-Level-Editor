namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 16)]
    public class igVscConstVec4fAccessor : igVscVec4fAccessor
    {
        [FieldAttr(ctr: 16)] public igVec4fMetaField _value = new();
    }
}
