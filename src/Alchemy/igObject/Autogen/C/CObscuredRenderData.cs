namespace Alchemy
{
    [ObjectAttr(ctr: 16, align: 4)]
    public class CObscuredRenderData : igObject
    {
        [FieldAttr(ctr: 12)] public bool _enableObscuredRendering;
    }
}
