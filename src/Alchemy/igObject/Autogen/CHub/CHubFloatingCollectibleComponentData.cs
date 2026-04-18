namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CHubFloatingCollectibleComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _rotateSpeed;
        [FieldAttr(ctr: 20)] public float _velocitySpeed;
        [FieldAttr(ctr: 24)] public float _upDownHeight;
        [FieldAttr(ctr: 28)] public float _upDownSpeed;
        [FieldAttr(ctr: 32)] public igEntity? _portalModel;
        [FieldAttr(ctr: 40)] public bool _isTutorialPortal;
    }
}
