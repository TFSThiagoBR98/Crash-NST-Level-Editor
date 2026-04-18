namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CCameraSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CEntityData? _dummyEntityData;
        [FieldAttr(nst: 24, ctr: 24)] public CCameraZoomSystem? _cameraZoomSystem;
    }
}
