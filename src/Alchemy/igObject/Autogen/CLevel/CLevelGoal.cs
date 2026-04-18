namespace Alchemy
{
    [ObjectAttr(ctr: 168, align: 8)]
    public class CLevelGoal : CObjective
    {
        [FieldAttr(ctr: 144)] public int _progressRequiredForCompletion;
        [FieldAttr(ctr: 148)] public bool _resetProgressOnCancel;
        [FieldAttr(ctr: 152)] public ELevelStars _levelStar;
        [FieldAttr(ctr: 156)] public bool _showIncrementalProgress;
        [FieldAttr(ctr: 157)] public bool _alwaysShowCounter;
        [FieldAttr(ctr: 158)] public bool _netReplicate;
        [FieldAttr(ctr: 160)] public int _progress;
    }
}
