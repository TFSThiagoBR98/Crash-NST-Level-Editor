namespace Alchemy
{
    [ObjectAttr(nst: 1840, align: 8)]
    public class CAirLinearVehicleHandlingComponentData : CBaseVehicleControllerComponentData
    {
        [FieldAttr(nst: 1776)] public float _deflectionTime;
        [FieldAttr(nst: 1780)] public float _resetTime;
        [FieldAttr(nst: 1784)] public igVec3fMetaField _anglesAtMaxDeflection = new();
        [FieldAttr(nst: 1796)] public igVec2fMetaField _speedAtMaxDeflection = new();
        [FieldAttr(nst: 1804)] public bool _doAnglesFromTargetPosition;
        [FieldAttr(nst: 1808)] public igVec2fMetaField _maxTargetOffset = new();
        [FieldAttr(nst: 1816)] public float _collisionQueryRadius = 138.0f;
        [FieldAttr(nst: 1820)] public bool _enableHavokCollision = true;
        [FieldAttr(nst: 1821)] public bool _enableRaycastCollision = true;
        [FieldAttr(nst: 1822)] public bool _usePhysics;
        [FieldAttr(nst: 1824)] public EXBUTTON _jumpButtonSecondary = EXBUTTON.JUMP;
        [FieldAttr(nst: 1828)] public float _barrelRollPushForce = 1.5f;
        [FieldAttr(nst: 1832)] public float _barrelRollTime = 0.5f;
        [FieldAttr(nst: 1836)] public float _barrelRollCooldownTime = 0.75f;
    }
}
