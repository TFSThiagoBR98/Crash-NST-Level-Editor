using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hkxMeshUserChannelInfo : hkxAttributeHolder
    {
        public override uint Hash => 0xa2c8a371;

        [FieldAttr(nst: 32, ctr: 32)] public string? _name;
        [FieldAttr(nst: 40, ctr: 40)] public string? _className;
    }
}