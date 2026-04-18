namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 8)]
    public class Color : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec4ucMetaField _storage = new();
    }
}
