namespace Alchemy
{
    [ObjectAttr(nst: 512, align: 16)]
    public class CCharacterLookCamera : CDefaultCamera
    {
        [FieldAttr(nst: 464)] public float _rotationRadius = 1200.0f;
        [FieldAttr(nst: 468)] public float _rotationSpeed_1 = 2.5f;
        [FieldAttr(nst: 472)] public float _targetElevation = 100.0f;
        [FieldAttr(nst: 476)] public float _cameraElevation = 125.0f;
        [FieldAttr(nst: 480)] public igVec3fMetaField _directionFromLookAtPointToCamera_1 = new();
        [FieldAttr(nst: 492)] public float _characterFollowRotationSmoothing = 0.1f;
        [FieldAttr(nst: 496)] public bool _isPlayerControlledRotationAllowed = true;
        [FieldAttr(nst: 497)] public bool _followCharacterIfNoPlayerInput = true;
    }
}
