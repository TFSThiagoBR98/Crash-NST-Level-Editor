namespace Havok
{
    public enum EDataType : u16
    {
        HKX_DT_NONE   = 0,
        HKX_DT_UINT8  = 1,
        HKX_DT_INT16  = 2,
        HKX_DT_UINT32 = 3,
        HKX_DT_FLOAT  = 4,
    }

    public enum ETriggerType : u8
    {
        TRIGGER_TYPE_NONE           = 0,
        TRIGGER_TYPE_BROAD_PHASE    = 1,
        TRIGGER_TYPE_NARROW_PHASE   = 2,
        TRIGGER_TYPE_CONTACT_SOLVER = 3,
    }

    public enum ECombinePolicy : u8
    {
        COMBINE_AVG = 0,
        COMBINE_MIN = 1,
        COMBINE_MAX = 2,
    }

    public enum EMassChangerCategory : u8
    {
        MASS_CHANGER_IGNORE = 0,
        MASS_CHANGER_DEBRIS = 1,
        MASS_CHANGER_HEAVY  = 2,
    }

    public enum EEnum : u8
    {
        CONVEX                  = 0,
        CONVEX_POLYTOPE         = 1,
        SPHERE                  = 2,
        CAPSULE                 = 3,
        TRIANGLE                = 4,
        COMPRESSED_MESH         = 5,
        EXTERN_MESH             = 6,
        STATIC_COMPOUND         = 7,
        DYNAMIC_COMPOUND        = 8,
        HEIGHT_FIELD            = 9,
        COMPRESSED_HEIGHT_FIELD = 10,
        SCALED_CONVEX           = 11,
        MASKED                  = 12,
        MASKED_COMPOUND         = 13,
        LOD                     = 14,
        DUMMY                   = 15,
        USER_0                  = 16,
        USER_1                  = 17,
        USER_2                  = 18,
        USER_3                  = 19,
        NUM_SHAPE_TYPES         = 20,
        INVALID                 = 21,
    }

    public enum ESimulationType : u8
    {
        SIMULATION_TYPE_SINGLE_THREADED = 0,
        SIMULATION_TYPE_MULTI_THREADED  = 1,
    }

    public enum ELeavingBroadPhaseBehavior : u8
    {
        ON_LEAVING_BROAD_PHASE_DO_NOTHING  = 0,
        ON_LEAVING_BROAD_PHASE_REMOVE_BODY = 1,
        ON_LEAVING_BROAD_PHASE_FREEZE_BODY = 2,
    }

    public enum EType : i8
    {
        INVALID   = 0,
        TRIANGLE  = 1,
        QUAD      = 2,
        CUSTOM    = 3,
        NUM_TYPES = 4,
    }

    public enum EhkaReferenceFrameTypeEnum : i8
    {
        REFERENCE_FRAME_UNKNOWN    = 0,
        REFERENCE_FRAME_DEFAULT    = 1,
        REFERENCE_FRAME_PARAMETRIC = 2,
    }

    public enum EAnimationType : int
    {
        HK_UNKNOWN_ANIMATION               = 0,
        HK_INTERLEAVED_ANIMATION           = 1,
        HK_MIRRORED_ANIMATION              = 2,
        HK_SPLINE_COMPRESSED_ANIMATION     = 3,
        HK_QUANTIZED_COMPRESSED_ANIMATION  = 4,
        HK_PREDICTIVE_COMPRESSED_ANIMATION = 5,
        HK_REFERENCE_POSE_ANIMATION        = 6,
    }

    public enum EBlendHint : i8
    {
        NORMAL              = 0,
        ADDITIVE_DEPRECATED = 1,
        ADDITIVE            = 2,
    }

    public enum EIndexType : i8
    {
        INDEX_TYPE_INVALID   = 0,
        INDEX_TYPE_TRI_LIST  = 1,
        INDEX_TYPE_TRI_STRIP = 2,
        INDEX_TYPE_TRI_FAN   = 3,
        INDEX_TYPE_MAX_ID    = 4,
    }

    public enum EDataUsage : u16
    {
        HKX_DU_NONE         = 0,
        HKX_DU_POSITION     = 1,
        HKX_DU_COLOR        = 2,
        HKX_DU_NORMAL       = 4,
        HKX_DU_TANGENT      = 8,
        HKX_DU_BINORMAL     = 16,
        HKX_DU_TEXCOORD     = 32,
        HKX_DU_BLENDWEIGHTS = 64,
        HKX_DU_BLENDINDICES = 128,
        HKX_DU_USERDATA     = 256,
    }

    public enum EUVMappingAlgorithm : uint
    {
        UVMA_SRT          = 0,
        UVMA_TRS          = 1,
        UVMA_3DSMAX_STYLE = 2,
        UVMA_MAYA_STYLE   = 3,
    }

    public enum ETransparency : u8
    {
        transp_none        = 0,
        transp_alpha       = 2,
        transp_additive    = 3,
        transp_colorkey    = 4,
        transp_subtractive = 9,
    }

    public enum ETextureType : int
    {
        TEX_UNKNOWN          = 0,
        TEX_DIFFUSE          = 1,
        TEX_REFLECTION       = 2,
        TEX_BUMP             = 3,
        TEX_NORMAL           = 4,
        TEX_DISPLACEMENT     = 5,
        TEX_SPECULAR         = 6,
        TEX_SPECULARANDGLOSS = 7,
        TEX_OPACITY          = 8,
        TEX_EMISSIVE         = 9,
        TEX_REFRACTION       = 10,
        TEX_GLOSS            = 11,
        TEX_DOMINANTS        = 12,
        TEX_NOTEXPORTED      = 13,
    }

    public enum EVariableMode : i8
    {
        VARIABLE_MODE_DISCARD_WHEN_INACTIVE         = 0,
        VARIABLE_MODE_MAINTAIN_VALUES_WHEN_INACTIVE = 1,
    }

    public enum EVariableType : i8
    {
        VARIABLE_TYPE_INVALID    = -1,
        VARIABLE_TYPE_BOOL       = 0,
        VARIABLE_TYPE_INT8       = 1,
        VARIABLE_TYPE_INT16      = 2,
        VARIABLE_TYPE_INT32      = 3,
        VARIABLE_TYPE_REAL       = 4,
        VARIABLE_TYPE_POINTER    = 5,
        VARIABLE_TYPE_VECTOR3    = 6,
        VARIABLE_TYPE_VECTOR4    = 7,
        VARIABLE_TYPE_QUATERNION = 8,
    }

    public enum ERole : i16
    {
        kListener  = 0,
        kInitiator = 1,
    }

    public enum ECloneState : i8
    {
        CLONE_STATE_DEFAULT  = 0,
        CLONE_STATE_TEMPLATE = 1,
        CLONE_STATE_CLONE    = 2,
    }

    public enum EhkbNodeType : u8
    {
        HKB_NODE_TYPE_INVALID                                      = 0,
        HKB_NODE_TYPE_FIRST_GENERATOR                              = 1,
        HKB_NODE_TYPE_BEHAVIOR_GRAPH                               = 1,
        HKB_NODE_TYPE_BEHAVIOR_REFERENCE_GENERATOR                 = 2,
        HKB_NODE_TYPE_BLENDER_GENERATOR                            = 3,
        HKB_NODE_TYPE_CLIP_GENERATOR                               = 4,
        HKB_NODE_TYPE_MANUAL_SELECTOR_GENERATOR                    = 5,
        HKB_NODE_TYPE_MODIFIER_GENERATOR                           = 6,
        HKB_NODE_TYPE_REFERENCE_POSE_GENERATOR                     = 7,
        HKB_NODE_TYPE_STATE_MACHINE                                = 8,
        HKB_NODE_TYPE_SCRIPT_GENERATOR                             = 9,
        HKB_NODE_TYPE_LAYER_GENERATOR                              = 10,
        HKB_NODE_TYPE_DOCKING_GENERATOR                            = 11,
        HKB_NODE_TYPE_END_OF_SPU_GENERATORS                        = 12,
        HKB_NODE_TYPE_PARAMETRIC_MOTION_GENERATOR                  = 12,
        HKB_NODE_TYPE_PIN_BONE_GENERATOR                           = 13,
        HKB_NODE_TYPE_OTHER_GENERATOR                              = 14,
        HKB_NODE_TYPE_FIRST_TRANSITION_EFFECT                      = 48,
        HKB_NODE_TYPE_BLENDING_TRANSITION_EFFECT                   = 48,
        HKB_NODE_TYPE_GENERATOR_TRANSITION_EFFECT                  = 49,
        HKB_NODE_TYPE_END_OF_SPU_TRANSITION_EFFECTS                = 50,
        HKB_NODE_TYPE_MANUAL_SELECTOR_TRANSITION_EFFECT            = 50,
        HKB_NODE_TYPE_FIRST_MODIFIER                               = 64,
        HKB_NODE_TYPE_ATTACHMENT_MODIFIER                          = 64,
        HKB_NODE_TYPE_ATTRIBUTE_MODIFIER                           = 65,
        HKB_NODE_TYPE_CHARACTER_CONTROLLER_MODIFIER                = 66,
        HKB_NODE_TYPE_COMBINE_TRANSFORMS_MODIFIER                  = 67,
        HKB_NODE_TYPE_COMPUTE_DIRECTION_MODIFIER                   = 68,
        HKB_NODE_TYPE_COMPUTE_ROTATION_FROM_AXIS_ANGLE_MODIFIER    = 69,
        HKB_NODE_TYPE_COMPUTE_ROTATION_TO_TARGET_MODIFIER          = 70,
        HKB_NODE_TYPE_DAMPING_MODIFIER                             = 71,
        HKB_NODE_TYPE_DELAYED_MODIFIER                             = 72,
        HKB_NODE_TYPE_EVALUATE_EXPRESSION_MODIFIER                 = 73,
        HKB_NODE_TYPE_EVENTS_FROM_RANGE_MODIFIER                   = 74,
        HKB_NODE_TYPE_EVENT_DRIVEN_MODIFIER                        = 75,
        HKB_NODE_TYPE_FOOT_IK_CONTROLS_MODIFIER                    = 76,
        HKB_NODE_TYPE_GET_WORLD_FROM_MODEL_MODIFIER                = 77,
        HKB_NODE_TYPE_HAND_IK_CONTROLS_MODIFIER                    = 78,
        HKB_NODE_TYPE_KEYFRAME_BONES_MODIFIER                      = 79,
        HKB_NODE_TYPE_LOOK_AT_MODIFIER                             = 80,
        HKB_NODE_TYPE_MIRROR_MODIFIER                              = 81,
        HKB_NODE_TYPE_MODIFIER_LIST                                = 82,
        HKB_NODE_TYPE_MOVE_BONE_ATTACHMENT_MODIFIER                = 83,
        HKB_NODE_TYPE_MOVE_CHARACTER_MODIFIER                      = 84,
        HKB_NODE_TYPE_POWERED_RAGDOLL_CONTROLS_MODIFIER            = 85,
        HKB_NODE_TYPE_RIGID_BODY_RAGDOLL_CONTROLS_MODIFIER         = 86,
        HKB_NODE_TYPE_ROTATE_CHARACTER_MODIFIER                    = 87,
        HKB_NODE_TYPE_SET_WORLD_FROM_MODEL_MODIFIER                = 88,
        HKB_NODE_TYPE_TIMER_MODIFIER                               = 89,
        HKB_NODE_TYPE_TRANSFORM_VECTOR_MODIFIER                    = 90,
        HKB_NODE_TYPE_TWIST_MODIFIER                               = 91,
        HKB_NODE_TYPE_END_OF_SPU_MODIFIERS                         = 92,
        HKB_NODE_TYPE_DETECT_CLOSE_TO_GROUND_MODIFIER              = 92,
        HKB_NODE_TYPE_EVALUATE_HANDLE_MODIFIER                     = 93,
        HKB_NODE_TYPE_GET_HANDLE_ON_BONE_MODIFIER                  = 94,
        HKB_NODE_TYPE_GET_UP_MODIFIER                              = 95,
        HKB_NODE_TYPE_JIGGLER_MODIFIER                             = 96,
        HKB_NODE_TYPE_SENSE_HANDLE_MODIFIER                        = 97,
        HKB_NODE_TYPE_SEQUENCE                                     = 98,
        HKB_NODE_TYPE_AI_STEERING_MODIFIER                         = 99,
        HKB_NODE_TYPE_AI_CONTROL_MODIFIER                          = 100,
        HKB_NODE_TYPE_ROCKETBOX_CHARACTER_CONTROLLER_MODIFIER      = 101,
        HKB_NODE_TYPE_LEAN_ROCKETBOX_CHARACTER_CONTROLLER_MODIFIER = 102,
        HKB_NODE_TYPE_OTHER_MODIFIER                               = 103,
        HKB_NODE_TYPE_TFB_ADDITIVESCALE_MODIFIER                   = 104,
    }

    public enum ERoleFlags : i16
    {
        FLAG_NONE                   = 0,
        FLAG_RAGDOLL                = 1,
        FLAG_NORMALIZED             = 2,
        FLAG_NOT_VARIABLE           = 4,
        FLAG_HIDDEN                 = 8,
        FLAG_OUTPUT                 = 16,
        FLAG_NOT_CHARACTER_PROPERTY = 32,
        FLAG_CHAIN                  = 64,
    }

    public enum EBindingType : i8
    {
        BINDING_TYPE_VARIABLE           = 0,
        BINDING_TYPE_CHARACTER_PROPERTY = 1,
    }

    public enum EInternalBindingFlags : i8
    {
        FLAG_NONE   = 0,
        FLAG_OUTPUT = 1,
    }

    public enum EStartStateMode : i8
    {
        START_STATE_MODE_DEFAULT = 0,
        START_STATE_MODE_SYNC    = 1,
        START_STATE_MODE_RANDOM  = 2,
        START_STATE_MODE_CHOOSER = 3,
    }

    public enum EStateMachineSelfTransitionMode : i8
    {
        SELF_TRANSITION_MODE_NO_TRANSITION                   = 0,
        SELF_TRANSITION_MODE_TRANSITION_TO_START_STATE       = 1,
        SELF_TRANSITION_MODE_FORCE_TRANSITION_TO_START_STATE = 2,
    }

    public enum ETransitionFlags : i16
    {
        FLAG_USE_TRIGGER_INTERVAL                               = 1,
        FLAG_USE_INITIATE_INTERVAL                              = 2,
        FLAG_UNINTERRUPTIBLE_WHILE_PLAYING                      = 4,
        FLAG_UNINTERRUPTIBLE_WHILE_DELAYED                      = 8,
        FLAG_DELAY_STATE_CHANGE                                 = 16,
        FLAG_DISABLED                                           = 32,
        FLAG_DISALLOW_RETURN_TO_PREVIOUS_STATE                  = 64,
        FLAG_DISALLOW_RANDOM_TRANSITION                         = 128,
        FLAG_DISABLE_CONDITION                                  = 256,
        FLAG_ALLOW_SELF_TRANSITION_BY_TRANSITION_FROM_ANY_STATE = 512,
        FLAG_IS_GLOBAL_WILDCARD                                 = 1024,
        FLAG_IS_LOCAL_WILDCARD                                  = 2048,
        FLAG_FROM_NESTED_STATE_ID_IS_VALID                      = 4096,
        FLAG_TO_NESTED_STATE_ID_IS_VALID                        = 8192,
        FLAG_ABUT_AT_END_OF_FROM_GENERATOR                      = 16384,
    }

    public enum ESelfTransitionMode : i8
    {
        SELF_TRANSITION_MODE_CONTINUE_IF_CYCLIC_BLEND_IF_ACYCLIC = 0,
        SELF_TRANSITION_MODE_CONTINUE                            = 1,
        SELF_TRANSITION_MODE_RESET                               = 2,
        SELF_TRANSITION_MODE_BLEND                               = 3,
    }

    public enum EEventMode : i8
    {
        EVENT_MODE_DEFAULT               = 0,
        EVENT_MODE_PROCESS_ALL           = 1,
        EVENT_MODE_IGNORE_FROM_GENERATOR = 2,
        EVENT_MODE_IGNORE_TO_GENERATOR   = 3,
    }

    public enum EPlaybackMode : i8
    {
        MODE_SINGLE_PLAY     = 0,
        MODE_LOOPING         = 1,
        MODE_USER_CONTROLLED = 2,
        MODE_PING_PONG       = 3,
        MODE_COUNT           = 4,
    }

    public enum EFlagBits : u16
    {
        FLAG_NONE                                = 0,
        FLAG_IGNORE_FROM_WORLD_FROM_MODEL        = 1,
        FLAG_SYNC                                = 2,
        FLAG_IGNORE_TO_WORLD_FROM_MODEL          = 4,
        FLAG_IGNORE_TO_WORLD_FROM_MODEL_ROTATION = 8,
    }

    public enum EEndMode : i8
    {
        END_MODE_NONE                                   = 0,
        END_MODE_TRANSITION_UNTIL_END_OF_FROM_GENERATOR = 1,
        END_MODE_CAP_DURATION_AT_END_OF_FROM_GENERATOR  = 2,
    }

    public enum EBlendCurve : i8
    {
        BLEND_CURVE_SMOOTH           = 0,
        BLEND_CURVE_LINEAR           = 1,
        BLEND_CURVE_LINEAR_TO_SMOOTH = 2,
        BLEND_CURVE_SMOOTH_TO_LINEAR = 3,
    }

    public enum EAdditionMode : u8
    {
        DO_NOT_ADD_BODY       = 0,
        ADD_BODY_NOW          = 1,
        ADD_BODY_IN_NEXT_STEP = 2,
    }

    public enum EInitialVelocityCoordinates : i8
    {
        INITIAL_VELOCITY_IN_WORLD_COORDINATES = 0,
        INITIAL_VELOCITY_IN_MODEL_COORDINATES = 1,
    }

    public enum EMotionMode : i8
    {
        MOTION_MODE_FOLLOW_ANIMATION = 0,
        MOTION_MODE_DYNAMIC          = 1,
    }

    public enum ESetAngleMethod : i8
    {
        LINEAR = 0,
        RAMPED = 1,
    }

    public enum ERotationAxisCoordinates : i8
    {
        ROTATION_AXIS_IN_MODEL_COORDINATES  = 0,
        ROTATION_AXIS_IN_PARENT_COORDINATES = 1,
        ROTATION_AXIS_IN_LOCAL_COORDINATES  = 2,
    }

    public enum EDockingFlagBits : u16
    {
        FLAG_NONE                    = 0,
        FLAG_DOCK_TO_FUTURE_POSITION = 1,
        FLAG_OVERRIDE_MOTION         = 2,
    }

}