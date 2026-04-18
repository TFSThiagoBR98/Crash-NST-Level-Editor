namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGUIEventAnimateRaceLeaderItems : igGuiEvent
    {
        [FieldAttr(ctr: 24)] public float _animationTime;
        [FieldAttr(ctr: 28)] public float _translateAmountX;
        [FieldAttr(ctr: 32)] public EigEaseType _easeType;
        [FieldAttr(ctr: 36)] public EigEaseMode _easeMode;
        [FieldAttr(ctr: 40)] public igVec3fMetaField _destination = new();
        [FieldAttr(ctr: 52)] public igVec3fMetaField _origin = new();
        [FieldAttr(ctr: 64)] public int _newPosition;
    }
}
