namespace Alchemy
{
    [ObjectAttr(nst: 464, ctr: 496, align: 16)]
    public class CStackCamera : CCamera
    {
        [FieldAttr(nst: 416, ctr: 448)] public CStackCameraControllerList? _defaultCameraControllers;
        [FieldAttr(nst: 424, ctr: 456)] public float _distanceOfTeleportThatCausesReset = 200.0f;
        [FieldAttr(nst: 428, ctr: 460)] public EPlayerId _playerId;
        [FieldAttr(nst: 432, ctr: 464)] public CStackCameraControllerList? _currentCameraControllers;
        [FieldAttr(nst: 440, ctr: 472)] public CBlackboard? _blackboard;
        [FieldAttr(nst: 448, ctr: 480)] public CChangeRequest? _disableZoom;
    }
}
