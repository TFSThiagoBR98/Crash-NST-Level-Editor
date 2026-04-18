namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class igVscConstVec2fAccessor : igVscVec2fAccessor
    {
        [FieldAttr(nst: 24)] public igVec2fMetaField _value = new();
    }
}
