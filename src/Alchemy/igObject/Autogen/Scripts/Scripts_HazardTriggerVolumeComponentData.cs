namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_HazardTriggerVolumeComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_HazardTriggerVolumeComponent_
    {
        public enum EOnTriggerVolumeRegisterTypes
        {
            OnEnter = 0,
            OnTouch = 1,
        }

        [FieldAttr(nst: 40)] public bool ActiveAtStartup = true;
        [FieldAttr(nst: 48)] public CEntityMessage? StartMessage;
        [FieldAttr(nst: 56)] public CEntityMessage? StopMessage;
        [FieldAttr(nst: 64)] public EOnTriggerVolumeRegisterTypes OnTriggerHandler;
        [FieldAttr(nst: 72)] public CTriggerVolumeComponentData? TriggerVolume;
        [FieldAttr(nst: 80)] public CDamageData? DamageData;
        [FieldAttr(nst: 88)] public CDamageData? DamageDataPVP;
        [FieldAttr(nst: 96)] public bool NotifyFriendsOnce;
        [FieldAttr(nst: 104)] public CVfxEffectDotNetHandle? HazardOnVfx;
        [FieldAttr(nst: 112)] public igHandleMetaField HazardOnVfxBoltPoint = new();
        [FieldAttr(nst: 120)] public igHandleMetaField HazardOnSfx = new();
        [FieldAttr(nst: 128)] public float HazardOnSFXFadoutTime = 0.25f;
        [FieldAttr(nst: 132)] public float Cooldown = 1.0f;
        [FieldAttr(nst: 136)] public bool SizeChangeOverTime;
        [FieldAttr(nst: 144)] public RangedFloat? SizeRange;
        [FieldAttr(nst: 152)] public float SizeChangeDuration = 3.0f;
        [FieldAttr(nst: 156)] public float SizeChangeStartDelay;
    }
}
