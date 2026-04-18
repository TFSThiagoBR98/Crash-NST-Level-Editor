namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CGuiBehaviorSwapMaterialsByGame : igGuiBehavior
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _crash1Material = new();
        [FieldAttr(nst: 24)] public igHandleMetaField _crash2Material = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _crash3Material = new();
    }
}
