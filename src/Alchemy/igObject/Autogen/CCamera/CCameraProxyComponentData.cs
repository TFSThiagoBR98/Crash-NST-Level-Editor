namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CCameraProxyComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public CCameraBase? _camera;
        [FieldAttr(nst: 32, ctr: 24)] public bool _activateOnEnable;
    }
}
