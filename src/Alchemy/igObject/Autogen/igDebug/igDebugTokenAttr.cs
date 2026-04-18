namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class igDebugTokenAttr : igAttr
    {
        [FieldAttr(nst: 24, ctr: 20)] public int _tag = -1;
        [FieldAttr(nst: 28, ctr: 24)] public bool _breakOnToken;
    }
}
