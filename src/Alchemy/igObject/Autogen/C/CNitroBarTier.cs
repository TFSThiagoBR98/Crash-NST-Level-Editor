namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CNitroBarTier : igObject
    {
        [FieldAttr(ctr: 16)] public string? _tierName;
        [FieldAttr(ctr: 24)] public igVec4ucMetaField _tierColorA = new();
        [FieldAttr(ctr: 28)] public igVec4ucMetaField _tierColorB = new();
    }
}
