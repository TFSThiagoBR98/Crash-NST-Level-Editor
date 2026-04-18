namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_AnimateEntityComponentComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_AnimateEntityComponent_
    {
        [FieldAttr(nst: 40)] public bool PlayAnimationToSelf;
        [FieldAttr(nst: 48)] public string? AnimationToPlay = null;
        [FieldAttr(nst: 56)] public bool IsLooping;
        [FieldAttr(nst: 57)] public bool PlayOnEnable;
        [FieldAttr(nst: 58)] public bool ResetOnActivate = true;
        [FieldAttr(nst: 64)] public CTelegramList? TimedTelegrams;
        [FieldAttr(nst: 72)] public int MaxTelegramsToSend = -1;
    }
}
