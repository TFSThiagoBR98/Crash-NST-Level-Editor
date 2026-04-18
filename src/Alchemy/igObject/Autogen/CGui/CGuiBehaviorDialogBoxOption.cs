namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 168, align: 8)]
    public class CGuiBehaviorDialogBoxOption : CGuiBehavior
    {
        public enum EGuiDialogBoxOption
        {
            eGDBO_OptionNone = 0,
            eGDBO_Option1 = 1,
            eGDBO_Option2 = 2,
        }

        [FieldAttr(nst: 144, ctr: 140)] public EGuiDialogBoxOption _option;
        [FieldAttr(nst: 152, ctr: 144, refCount: false)] public igGuiPlaceable? _text;
        [FieldAttr(nst: 160, ctr: 152)] public CDialogBoxInfo? _dialogBoxInfo;
        [FieldAttr(nst: 168, ctr: 160)] public CScopedScheduledFunctionList? _scheduledTelegrams;
    }
}
