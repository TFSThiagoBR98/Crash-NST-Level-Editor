namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class COpenUiAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 40)] public igStringRefList? _uiExclusionList;
        [FieldAttr(ctr: 48)] public EOpenUIActionState _state;
        [FieldAttr(ctr: 56)] public igStringRefList? _uiTestList;
    }
}
