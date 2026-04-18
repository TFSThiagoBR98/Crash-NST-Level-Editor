namespace Alchemy
{
    [ObjectAttr(nst: 168, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CutsceneSequenceShotHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsFadeInEnable;
        [FieldAttr(nst: 41)] public bool _IsFadeOutEnable;
        [FieldAttr(nst: 42)] public bool _IsUseDialog;
        [FieldAttr(nst: 43)] public bool _IsDialogOverrideSequenceDuration;
        [FieldAttr(nst: 44)] public bool _IsCloseDialogOnSequenceShotDone;
        [FieldAttr(nst: 45)] public bool _IsCameraActiveGameplayCamera;
        [FieldAttr(nst: 48)] public igHandleMetaField _Camera = new();
        [FieldAttr(nst: 56)] public EigEaseMode _CameraEaseMode;
        [FieldAttr(nst: 60)] public EigEaseType _CameraEaseType;
        [FieldAttr(nst: 64)] public igHandleMetaField _DialogSpeaker = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _FadeInPreset = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _FadeOutPreset = new();
        [FieldAttr(nst: 88)] public float _SequenceDuration;
        [FieldAttr(nst: 92)] public float _DialogCadence;
        [FieldAttr(nst: 96)] public float _DelayDialogStart;
        [FieldAttr(nst: 100)] public float _CameraBlendInTime;
        [FieldAttr(nst: 104)] public igHandleMetaField _DialogLine = new();
        [FieldAttr(nst: 112)] public bool _Bool;
        [FieldAttr(nst: 120)] public igHandleMetaField _Entity_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity_0x80 = new();
        [FieldAttr(nst: 136)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 140)] public float _Float_0x8c;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public igKeyboardInputDevice.ESignal _Keyboard_Input_Device_Signal_0x98;
        [FieldAttr(nst: 156)] public igKeyboardInputDevice.ESignal _Keyboard_Input_Device_Signal_0x9c;
        [FieldAttr(nst: 160)] public float _Float_0xa0;
    }
}
