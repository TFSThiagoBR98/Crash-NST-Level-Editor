namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 224, align: 8, meta: true)]
    public class CInteractionData : Object
    {
        public enum EInteractPromptAreaType
        {
            eIPAT_Radius = 0,
            eIPAT_TriggerVolumeComponent = 1,
        }

        [FieldAttr(nst: 32, ctr: 32)] public CInteractionRestriction? _restriction;
        [FieldAttr(nst: 40, ctr: 40)] public bool _waitForButtonRelease;
        [FieldAttr(nst: 44, ctr: 44)] public int _interactionPriority;
        [FieldAttr(nst: 48, ctr: 48)] public bool _boltAlertPrompt = true;
        [FieldAttr(nst: 56, ctr: 56)] public CBoltPoint? _boltPoint;
        [FieldAttr(nst: 64, ctr: 64)] public igVec3fMetaField _boltPointOffset = new();
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _alertPromptUI = new();
        [FieldAttr(nst: 88, ctr: 88)] public float _alertPromptDistance = 2000.0f;
        [FieldAttr(nst: 92, ctr: 92)] public bool _displayInteractPrompt = true;
        [FieldAttr(nst: 93, ctr: 93)] public bool _boltInteractPrompt = true;
        [FieldAttr(nst: 96, ctr: 96)] public CBoltPoint? _interactVfxBoltPoint;
        [FieldAttr(nst: 104, ctr: 104)] public igVec3fMetaField _interactVfxBoltPointOffset = new();
        [FieldAttr(nst: 116, ctr: 116)] public EInteractPromptAreaType _interactPromptAreaType;
        [FieldAttr(nst: 120, ctr: 120)] public float _interactPromptDistance = 300.0f;
        [FieldAttr(nst: 124, ctr: 124)] public bool _supportCannotInteract = true;
        [FieldAttr(nst: 128, ctr: 128)] public igHandleMetaField _cannotInteractPromptUI = new();
        [FieldAttr(nst: 136, ctr: 136)] public igHandleMetaField _entityToBoltTo = new();
        [FieldAttr(nst: 144, ctr: 144)] public bool _whenOutOfRangeKillVfxImmediately;
        [FieldAttr(nst: 145, ctr: 145)] public bool _softKillForPendingVfx;
        [FieldAttr(nst: 152, ctr: 152)] public igVfxEffectHandleList? _additionalInteractVfx;
        [FieldAttr(nst: 160, ctr: 160)] public EXBUTTON _interactKey = EXBUTTON.R1;
        [FieldAttr(nst: 164, ctr: 164)] public bool _sendMessageToEntity = true;
        [FieldAttr(nst: 168, ctr: 168)] public igHandleMetaField _onInteractSfx = new();
        [FieldAttr(nst: 176, ctr: 176)] public CEntityMessage? _interactionMessage;
        [FieldAttr(nst: 184, ctr: 184)] public CEntityMessage? _heldButtonInteractionStart;
        [FieldAttr(nst: 192, ctr: 192)] public CEntityHandleList? _messageRecipients;
        [FieldAttr(nst: 200, ctr: 200)] public bool _broadcastMessage;
        [FieldAttr(nst: 208, ctr: 208)] public CEntitySphere? _broadcastSphere;
        [FieldAttr(nst: 216, ctr: 216)] public float _stateCooldownInSeconds;
    }
}
