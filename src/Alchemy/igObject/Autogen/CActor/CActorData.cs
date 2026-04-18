namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 288, align: 8)]
    public class CActorData : CPhysicalEntityData
    {
        public enum EActorDataFlags
        {
            eADF_None = 0,
            eADF_SpawnExactLocation = 16,
        }

        [FieldAttr(nst: 144, ctr: 140)] public uint _actorDataFlags = 16;
        [FieldAttr(nst: 152, ctr: 144)] public string? _character = null;
        [FieldAttr(nst: 160, ctr: 152)] public string? _skin = null;
        [FieldAttr(nst: 168, ctr: 160)] public string? _magicMomentModel = null;
        [FieldAttr(nst: 176, ctr: 168)] public float _magicMomentSpawnBackgroundVfxOverrideTime = -1.0f;
        [FieldAttr(nst: 180, ctr: 172)] public float _magicMomentSpawnOutroVfxOverrideTime = -1.0f;
        [FieldAttr(nst: 184, ctr: 176)] public float _magicMomentStartEndVfxOverrideTime = -1.0f;
        [FieldAttr(nst: 188, ctr: 180)] public float _magicMomentShowNameOverrideTime = -1.0f;
        [FieldAttr(nst: 192, ctr: 184)] public float _magicMomentHideNameOverrideTime = -1.0f;
        [FieldAttr(nst: 196, ctr: 188)] public float _magicMomentPauseIntroAnimationOverrideTime = -1.0f;
        [FieldAttr(nst: 200, ctr: 192)] public float _magicMomentJumpOutTimeFromEndOverride = -1.0f;
        [FieldAttr(nst: 208, ctr: 200)] public string? _characterAnimations = null;
        [FieldAttr(nst: 216, ctr: 208)] public string? _characterAnimationBase = null;
        [FieldAttr(nst: 224, ctr: 216)] public CAudioArchiveHandleList? _soundBankHandleList;
        [FieldAttr(nst: 232, ctr: 224)] public string? _characterScript = null;
        [FieldAttr(nst: 240, ctr: 232)] public float _aiAlertRange;
        [FieldAttr(nst: 244, ctr: 236)] public EAllowedHitReactDirections _takeHitReactDirections = EAllowedHitReactDirections.eAHRD_NoDirection;
        [FieldAttr(nst: 248, ctr: 240)] public EAllowedHitReactDirections _partialHitReactDirections;
        [FieldAttr(nst: 252, ctr: 244)] public EAllowedHitReactDirections _knockawayReactDirections = EAllowedHitReactDirections.eAHRD_NoDirection;
        [FieldAttr(nst: 256, ctr: 248)] public EAllowedHitReactDirections _deathReactDirections = EAllowedHitReactDirections.eAHRD_Front;
        [FieldAttr(nst: 260, ctr: 252)] public EAllowedHitReactDirections _knockawayDeathReactDirections;
        [FieldAttr(nst: 264, ctr: 256)] public igHandleMetaField _hudPortrait = new();
        [FieldAttr(ctr: 264)] public igHandleMetaField _minimapIcon = new();
        [FieldAttr(nst: 272, ctr: 272)] public igHandleMetaField _footstepEffect = new();
        [FieldAttr(nst: 280, ctr: 280)] public igHandleMetaField _magicMomentNameEffect = new();
    }
}
