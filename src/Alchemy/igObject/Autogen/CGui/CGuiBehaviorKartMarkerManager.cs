namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorKartMarkerManager : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _markerTemplate;
        [FieldAttr(ctr: 24)] public igGuiPlaceableHandleList? _markers;
    }
}
