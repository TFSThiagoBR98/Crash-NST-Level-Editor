namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class igCameraReferenceSettings : igObject
    {
        [FieldAttr(ctr: 12)] public EZoomSelectionOptions _zoomSelectionMode;
        [FieldAttr(ctr: 16)] public EZoomNoSelectionOptions _zoomNoSelectionMode;
        [FieldAttr(ctr: 20)] public ERotateSelectionOptions _rotateSelectionMode;
        [FieldAttr(ctr: 24)] public ERotateNoSelectionOptions _rotateNoSelectionMode;
        [FieldAttr(ctr: 28)] public EPanSelectionOptions _panSelectionMode;
        [FieldAttr(ctr: 32)] public EPanNoSelectionOptions _panNoSelectionMode;
        [FieldAttr(ctr: 36)] public bool _drawReferencePoint;
        [FieldAttr(ctr: 48)] public igVec4fMetaField _referencePointColor = new();
        [FieldAttr(ctr: 64)] public float _referencePointPixelSize;
    }
}
