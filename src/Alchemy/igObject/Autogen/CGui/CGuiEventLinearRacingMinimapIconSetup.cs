namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiEventLinearRacingMinimapIconSetup : igGuiEvent
    {
        [FieldAttr(ctr: 24)] public igVec3fMetaField _startPosition = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _endPosition = new();
        [FieldAttr(ctr: 48)] public igFloatList? _mapPathRatios;
    }
}
