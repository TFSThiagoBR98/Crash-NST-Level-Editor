namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneCheatInputData : igObject
    {
        [FieldAttr(ctr: 16)] public CGuiOctaneCheatSignalList? _inputSequence;
        [FieldAttr(ctr: 24)] public EOctaneCheats _cheatId;
        [FieldAttr(ctr: 28)] public int _currentSequenceIndex;
    }
}
