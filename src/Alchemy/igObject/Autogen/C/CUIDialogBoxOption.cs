namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 120, align: 8, meta: true)]
    public class CUIDialogBoxOption : Object
    {
        [FieldAttr(nst: 32, ctr: 32)] public string? _text = "";
        [FieldAttr(nst: 40)] public igRawRefMetaField _codeCallback = new();
        [FieldAttr(ctr: 40)] public EButtonLegendButton _input;
        [FieldAttr(nst: 48, ctr: 56)] public igRawRefMetaField _callbackUserData = new();
        [FieldAttr(nst: 56, ctr: 64)] public CEntityMessage? _optionSelectedMessage;
        [FieldAttr(nst: 64, ctr: 72)] public CEntityHandleList? _optionSelectedMessageRecipients;
        [FieldAttr(nst: 72, ctr: 80)] public CTelegramList? _optionSelectedTelegrams;
        [FieldAttr(nst: 80, ctr: 88)] public CScopedScheduledFunctionList? _scheduledTelegrams;
        [FieldAttr(nst: 88, ctr: 96)] public igHandleMetaField _selectionSound = new();
        [FieldAttr(nst: 96, ctr: 104)] public igVscDelegateMetaField _delegateCallback = new();
    }
}
