namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CScreenspaceTargetManager : CManager
    {
        public enum EScreenspaceTargetListType
        {
            eSTLT_Default = 0,
            eSTLT_Gearbit = 1,
        }

        [FieldAttr(nst: 16)] public CScreenspaceTargetList? _defaultTargets;
        [FieldAttr(nst: 24)] public CScreenspaceTargetList? _gearbitTargets;
        [FieldAttr(nst: 32)] public int[] _defaultUpdateIndices = new int[2];
        [FieldAttr(nst: 40)] public int[] _gearbitUpdateIndices = new int[4];
        [FieldAttr(nst: 56)] public bool _debugDrawBoxesEnabled;
        [FieldAttr(nst: 64)] public igAABox? _tempWorldBox;
        [FieldAttr(nst: 72)] public igAABox? _tempScreenBox;
        [FieldAttr(nst: 80)] public float _maxDefaultTargetRange = 15000.0f;
        [FieldAttr(nst: 84)] public float _maxGearbitTargetRange = 1.0f;
        [FieldAttr(nst: 88)] public int _numberOfTargetsOnScreen;
        [FieldAttr(nst: 96)] public COnScreenspaceTargetManagerPostUpdateDelegate? _onPostUpdate;
        [FieldAttr(nst: 104)] public COnScreenspaceTargetManagerPostUpdateEventList? _onPostUpdateEventList;
    }
}
