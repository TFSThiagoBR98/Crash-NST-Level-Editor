namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorLensFlare : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igNonRefCountedGuiPlaceableList? _flares;
        [FieldAttr(ctr: 24)] public bool _placeablesHidden;
        [FieldAttr(ctr: 25)] public bool _disabled;
    }
}
