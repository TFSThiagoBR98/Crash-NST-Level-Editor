namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CSmokeActionBaseList : igObjectList<CSmokeActionBase>
    {
        [FieldAttr(ctr: 40)] public bool _isDynamic;
        [FieldAttr(ctr: 48)] public string? _description;
        [FieldAttr(ctr: 56)] public bool _allowThreadedRender;
        [FieldAttr(ctr: 57)] public bool _disableVSync;
        [FieldAttr(ctr: 58)] public bool _forceHDR;
        [FieldAttr(ctr: 59)] public bool _allowAIPowerUpUsage;
    }
}
