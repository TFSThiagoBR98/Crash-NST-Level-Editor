namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 16)]
    public class CGuiRenderTargetDisplay : igGuiAsset
    {
        [FieldAttr(nst: 32)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(nst: 40)] public igSprite? _renderSprite;
        [FieldAttr(nst: 48)] public bool _flipUVs = true;
    }
}
