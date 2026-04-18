namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CCameraAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _cameraHandle = new();
        [FieldAttr(ctr: 48)] public float _transitionTime;
        [FieldAttr(ctr: 52)] public EigEaseType _easeType;
        [FieldAttr(ctr: 56)] public EigEaseMode _easeMode;
    }
}
