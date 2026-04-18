namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CGuiItemTierColors : igObject
    {
        [FieldAttr(ctr: 12)] public igVec4ucMetaField _focusedColor = new();
        [FieldAttr(ctr: 16)] public igVec4ucMetaField _unfocusedColor = new();
    }
}
