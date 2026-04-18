namespace Alchemy
{
    [ObjectAttr(ctr: 184, align: 8)]
    public class CGuiBehaviorOctaneCheatInput : CGuiBehavior
    {
        [FieldAttr(ctr: 144)] public CGuiOctaneCheatSignalList? _heldInputs;
        [FieldAttr(ctr: 152)] public int _heldInputCount;
        [FieldAttr(ctr: 160)] public COctaneCheatInputDataList? _cheats;
        [FieldAttr(ctr: 168)] public CGuiOctaneCheatSignalList? _inputSequence;
        [FieldAttr(ctr: 176)] public EOctaneCheats _cheatId;
    }
}
