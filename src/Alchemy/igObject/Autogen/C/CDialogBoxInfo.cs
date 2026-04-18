namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 200, align: 8)]
    public class CDialogBoxInfo : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CUIDialogBoxOption? _option1;
        [FieldAttr(nst: 24, ctr: 24)] public CUIDialogBoxOption? _option2;
        [FieldAttr(ctr: 32)] public CUIDialogBoxOption? _optionCancel;
        [FieldAttr(nst: 32, ctr: 40)] public CGuiBehaviorDialogBoxOption.EGuiDialogBoxOption _optionToFocus = CGuiBehaviorDialogBoxOption.EGuiDialogBoxOption.eGDBO_Option2;
        [FieldAttr(nst: 40, ctr: 48)] public string? _title = "";
        [FieldAttr(nst: 48, ctr: 56)] public string? _body = "";
        [FieldAttr(nst: 56, ctr: 64)] public string? _closeDialogLegendText = "";
        [FieldAttr(nst: 64, ctr: 72)] public bool _canAccept = true;
        [FieldAttr(nst: 65, ctr: 73)] public bool _canCancel = true;
        [FieldAttr(nst: 72)] public igRawRefMetaField _updateCallback = new();
        [FieldAttr(nst: 80)] public igRawRefMetaField _cancelCallback = new();
        [FieldAttr(nst: 88)] public igRawRefMetaField _closeCallback = new();
        [FieldAttr(nst: 96)] public igRawRefMetaField _inputCallback = new();
        [FieldAttr(ctr: 74)] public bool _canRefuse;
        [FieldAttr(ctr: 75)] public bool _showBackground;
        [FieldAttr(nst: 104, ctr: 112)] public igRawRefMetaField _callbackUserData = new();
        [FieldAttr(nst: 112, ctr: 120)] public CEntityMessage? _onCloseMessage;
        [FieldAttr(nst: 120, ctr: 128)] public CEntityHandleList? _onCloseMessageRecipients;
        [FieldAttr(nst: 128, ctr: 136)] public CTelegramList? _backOutTelegrams;
        [FieldAttr(nst: 136, ctr: 144)] public igHandleMetaField component = new();
        [FieldAttr(nst: 144, ctr: 152)] public bool _forcePause;
        [FieldAttr(nst: 148, ctr: 156)] public float _delayInputDuration;
        [FieldAttr(nst: 152, ctr: 160)] public igHandleMetaField _image = new();
        [FieldAttr(nst: 160, ctr: 168)] public EeDialogCloseSource _closeSource = EeDialogCloseSource.eDCS_CloseAllUI;
        [FieldAttr(nst: 168, ctr: 176)] public igVscDelegateMetaField _cancelDelegateCallback = new();
        [FieldAttr(ctr: 192)] public bool _useButtonPrompt;
        [FieldAttr(ctr: 193)] public bool _option2Cancels;
    }
}
