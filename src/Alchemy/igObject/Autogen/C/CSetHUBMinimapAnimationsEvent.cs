namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CSetHUBMinimapAnimationsEvent : igGuiEvent
    {
        [FieldAttr(ctr: 24)] public CEntity? _entity;
        [FieldAttr(ctr: 32)] public int _zoneIndex;
        [FieldAttr(ctr: 36)] public bool _isArena;
    }
}
