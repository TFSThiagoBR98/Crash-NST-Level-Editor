namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CTintSphereComponent : igComponent
    {
        [FieldAttr(ctr: 40)] public CRigidModelInstance? _model;
        [FieldAttr(ctr: 48)] public CTintSphereBundle? _tintSphereConstant;
        [FieldAttr(ctr: 56)] public bool _occlusionBoxHidden;
        [FieldAttr(ctr: 57)] public bool _lightState;
        [FieldAttr(ctr: 58)] public bool _isComponentEnabled;
        [FieldAttr(ctr: 59)] public bool _registered;
    }
}
