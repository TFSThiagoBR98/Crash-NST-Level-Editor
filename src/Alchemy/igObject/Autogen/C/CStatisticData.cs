namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CStatisticData : igObject
    {
        public enum EStatisticWriteType
        {
            eSWT_Invalid = -1,
            eSWT_Replace = 0,
            eSWT_Add = 1,
            eSWT_Max = 2,
            eSWT_Min = 3,
            eSWT_BitwiseOR = 4,
        }

        [FieldAttr(nst: 16, ctr: 12)] public ELeaderBoardID _leaderboardId;
        [FieldAttr(nst: 20, ctr: 16)] public i16 _keyArchiveId = -1;
        [FieldAttr(nst: 24, ctr: 20)] public EStatisticWriteType _writeType;
    }
}
