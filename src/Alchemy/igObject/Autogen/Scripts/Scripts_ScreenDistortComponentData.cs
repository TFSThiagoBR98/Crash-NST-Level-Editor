namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_ScreenDistortComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_ScreenDistortComponent_
    {
        [FieldAttr(nst: 40)] public string? ScreenDistortStartCustomEvent = "ScreenDistortOn";
        [FieldAttr(nst: 48)] public string? ScreenDistortStopCustomEvent = "ScreenDistortOff";
        [FieldAttr(nst: 56)] public float DistortStrength = 1.0f;
        [FieldAttr(nst: 60)] public EigEaseType DistortEaseType = EigEaseType.kEaseTypeSinusoidal;
        [FieldAttr(nst: 64)] public float DistortEaseRatioIn = 0.4f;
        [FieldAttr(nst: 68)] public float DistortEaseRatioOut = 0.4f;
    }
}
