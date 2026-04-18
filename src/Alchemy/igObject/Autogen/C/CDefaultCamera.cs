namespace Alchemy
{
    [ObjectAttr(nst: 464, align: 16)]
    public class CDefaultCamera : CConstrainedCamera
    {
        [FieldAttr(nst: 432)] public float _rotationSpeed = 1.39999998f;
        [FieldAttr(nst: 436)] public float _radius = 1200.0f;
        [FieldAttr(nst: 440)] public igVec3fMetaField _directionFromLookAtPointToCamera = new();
        [FieldAttr(nst: 452)] public EPlayerId _playerId = EPlayerId.EPLAYERID_NONE;
    }
}
