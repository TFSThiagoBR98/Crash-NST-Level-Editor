namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CPositionPortraitAnimationInfo : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _position = new();
        [FieldAttr(ctr: 24)] public CRacerList? _animationQueue;
        [FieldAttr(ctr: 32)] public CRacerPortraitInfo? _currentRacerInfo;
        [FieldAttr(ctr: 40)] public CRacerPortraitInfo? _incomingRacerInfo;
    }
}
