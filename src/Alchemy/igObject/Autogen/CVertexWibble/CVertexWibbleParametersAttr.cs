namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 16)]
    public class CVertexWibbleParametersAttr : igVisualAttribute
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField _amplitude = new();
        [FieldAttr(nst: 48)] public igVec4fMetaField _frequency = new();
        [FieldAttr(nst: 64)] public igVec4fMetaField _phase = new();
    }
}
