namespace Alchemy
{
    [ObjectAttr(nst: 168, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_VortexComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_VortexComponent_
    {
        [FieldAttr(nst: 40)] public bool StartOn;
        [FieldAttr(nst: 41)] public bool Repel;
        [FieldAttr(nst: 48)] public CTriggerVolumeSphereComponentData? VortexData;
        [FieldAttr(nst: 56)] public float VortexLife = -1.0f;
        [FieldAttr(nst: 60)] public bool RemoveVortexEntOnLifeEnd;
        [FieldAttr(nst: 64)] public float StartDelay;
        [FieldAttr(nst: 68)] public float VortexIntensityMax = 9.0f;
        [FieldAttr(nst: 72)] public float VortexIntensityMin = 4.0f;
        [FieldAttr(nst: 76)] public float VortexSuctionScale = 0.5f;
        [FieldAttr(nst: 80)] public bool KillVelocityOnRemove = true;
        [FieldAttr(nst: 88)] public CEntityMessage? StartMessageOverride;
        [FieldAttr(nst: 96)] public CEntityMessage? EndMessageOverride;
        [FieldAttr(nst: 104)] public bool SizeChangeOverTime;
        [FieldAttr(nst: 112)] public RangedFloat? SizeRange;
        [FieldAttr(nst: 120)] public float SizeChangeDuration = 3.0f;
        [FieldAttr(nst: 124)] public bool Orbit;
        [FieldAttr(nst: 128)] public float OrbitStrength = 5.0f;
        [FieldAttr(nst: 136)] public CEntityMessage? VictimEnterMessage;
        [FieldAttr(nst: 144)] public CEntityMessage? VictimExitMessage;
        [FieldAttr(nst: 152)] public CEntityMessage? SelfVictimEnterMessage;
        [FieldAttr(nst: 160)] public CEntityMessage? SelfVictimExitMessage;
    }
}
