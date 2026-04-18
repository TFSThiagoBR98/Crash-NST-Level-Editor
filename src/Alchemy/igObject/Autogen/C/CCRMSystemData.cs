namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CCRMSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _context = null;
        [FieldAttr(nst: 24, ctr: 24)] public igStringRefList? _movies;
        [FieldAttr(nst: 32, ctr: 32)] public bool _enableDebugMessages;
        [FieldAttr(nst: 40, ctr: 40)] public igStringRefList? _debugMessages;
    }
}
