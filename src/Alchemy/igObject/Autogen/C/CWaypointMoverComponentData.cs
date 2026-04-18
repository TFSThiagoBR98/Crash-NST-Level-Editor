namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 96, align: 8)]
    public class CWaypointMoverComponentData : CEntityComponentData
    {
        public enum EWaypointMoverSelectionType
        {
            eWMST_Default = 0,
            eWMST_Closest = 1,
        }

        public enum EWaypointMoverMoveMethod
        {
            eWMMM_Pathfinding = 0,
            eWMMM_StraightLine = 1,
            eWMMM_Reliable = 2,
        }

        public enum EWaypointMoverLoopMode
        {
            eWMLM_PlayOnce = 0,
            eWMLM_Loop = 1,
            eWMLM_PingPong = 2,
        }

        public enum EWaypointMoverMoveAnimation
        {
            eWMMA_Run = 0,
            eWMMA_Walk = 1,
            eWMMA_Custom = 2,
        }

        [FieldAttr(nst: 24, ctr: 16)] public CTraversalPath? _waypoints;
        [FieldAttr(nst: 32, ctr: 24)] public EWaypointMoverSelectionType _waypointSelectionType;
        [FieldAttr(nst: 40, ctr: 32)] public CTraversalPathList? _additionalWaypointLists;
        [FieldAttr(nst: 48, ctr: 40)] public EWaypointMoverMoveMethod _moveMethod;
        [FieldAttr(nst: 52, ctr: 44)] public EWaypointMoverLoopMode _loopMode;
        [FieldAttr(nst: 56, ctr: 48)] public bool _startMovingOnEnable;
        [FieldAttr(nst: 57, ctr: 49)] public bool _orientAtEnd;
        [FieldAttr(nst: 58, ctr: 50)] public bool _dieAtEnd;
        [FieldAttr(nst: 59, ctr: 51)] public bool _dieSilently = true;
        [FieldAttr(nst: 60, ctr: 52)] public float _rotationTime = 1.0f;
        [FieldAttr(nst: 64, ctr: 56)] public float _goalDistance = 40.0f;
        [FieldAttr(nst: 68, ctr: 60)] public EWaypointMoverMoveAnimation _moveAnimation;
        [FieldAttr(nst: 72, ctr: 64)] public float _customMoveSpeed = 1.0f;
        [FieldAttr(nst: 80, ctr: 72)] public string? _behaviorStartEvent = null;
        [FieldAttr(nst: 88, ctr: 80)] public string? _behaviorStopEvent = null;
        [FieldAttr(nst: 96, ctr: 88)] public bool _enableAIOnDamage;
        [FieldAttr(nst: 97, ctr: 89)] public bool _startMovingOnDamage;
    }
}
