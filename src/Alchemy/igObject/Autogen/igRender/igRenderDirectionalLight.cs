namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 16)]
    public class igRenderDirectionalLight : igRenderLight
    {
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _direction = new();
    }
}
