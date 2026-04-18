namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 144, align: 8)]
    public class CScriptTriggerEntityData : CGameEntityData
    {
        public enum EAabbMode
        {
            eAM_Never = 0,
            eAM_Auto = 1,
            eAM_Always = 2,
        }

        [FieldAttr(nst: 128, ctr: 124)] public uint _actFlags;
        [FieldAttr(nst: 132, ctr: 128)] public uint _scriptTriggerFlags = 128;
        [FieldAttr(nst: 136, ctr: 132)] public bool _attachedPlayersCanTrigger;
        [FieldAttr(nst: 140, ctr: 136)] public EAabbMode _aabbMode = CScriptTriggerEntityData.EAabbMode.eAM_Auto;
        [FieldAttr(nst: 144, ctr: 140)] public bool _networkEnabled;
    }
}
