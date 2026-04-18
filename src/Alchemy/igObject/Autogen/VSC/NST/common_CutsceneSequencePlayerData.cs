namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CutsceneSequencePlayerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsSkipFadeOn;
        [FieldAttr(nst: 41)] public bool _IsDebugCameraHoldForeverOn;
        [FieldAttr(nst: 42)] public bool _ExcludeStartingCheckpoint;
        [FieldAttr(nst: 43)] public bool _IsPlayOnStart;
        [FieldAttr(nst: 48)] public igHandleMetaField _Starting_Checkpoint = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _CutscenePreset = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _DesignCutsceneIdentifier = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _CutsceneSequenceShotList = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _FadeInPreset = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _SkipFadePreset = new();
        [FieldAttr(nst: 96)] public float _OnCutsceneDoneCameraBlendOutTime;
        [FieldAttr(nst: 100)] public igKeyboardInputDevice.ESignal _DebugKeyboardGoNextCameraShot;
        [FieldAttr(nst: 104)] public igHandleMetaField _Sound = new();
    }
}
