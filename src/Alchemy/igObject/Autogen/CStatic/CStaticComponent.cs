namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CStaticComponent : igComponent
    {
        [FieldAttr(ctr: 40)] public CModelInstance? _model;
        [FieldAttr(ctr: 48)] public ECastsShadows _castsShadows;
        [FieldAttr(ctr: 52)] public EMobileShadowStateOverride _mobileShadowState;
        [FieldAttr(ctr: 56)] public CCloudBundle? _cloudBundle;
        [FieldAttr(ctr: 64)] public bool _pendingUpdateMessage;
    }
}
