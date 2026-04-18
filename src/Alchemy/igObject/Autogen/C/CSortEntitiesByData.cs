namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 4)]
    public class CSortEntitiesByData : CSortEntities
    {
        public enum EDataSortMethod
        {
            eDSM_None = 0,
            eDSM_ClosestToFarthest = 1,
            eDSM_FarthestToClosest = 2,
            eDSM_MostHealthToLeast = 3,
            eDSM_LeastHealthToMost = 4,
            eDSM_LeftToRight = 5,
            eDSM_RightToLeft = 6,
        }

        [FieldAttr(nst: 16)] public EDataSortMethod _sortMethod;
    }
}
