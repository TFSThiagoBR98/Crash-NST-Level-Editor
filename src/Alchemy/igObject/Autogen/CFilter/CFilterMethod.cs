namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 4)]
    public class CFilterMethod : igObject
    {
        public enum EQueryFilterType
        {
            EQFT_OnlyKeepResultsInQuery = 0,
            EQFT_RemoveResultsFromQuery = 1,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EQueryFilterType _filterType;
    }
}
