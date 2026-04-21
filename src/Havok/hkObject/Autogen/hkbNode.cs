using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkbNode : hkbBindable
    {
        public override uint Hash => 0x8b4251f;

        [FieldAttr(nst: 48, ctr: 48)] public u64 _userData;
        [FieldAttr(nst: 56, ctr: 56)] public string? _name;
        [FieldAttr(nst: 64, ctr: 64)] public u16 _id;
        [FieldAttr(nst: 66, ctr: 66)] public ECloneState _cloneState;
        [FieldAttr(nst: 67, ctr: 67)] public EhkbNodeType _type;
        [FieldAttr(nst: 72, ctr: 72)] public uint _nodeInfo;
    }
}