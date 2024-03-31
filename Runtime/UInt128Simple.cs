namespace StinkySteak.Dirichlet.Numerics
{
    /// <summary>
    /// Can be serialized in Unity
    /// </summary>
    [System.Serializable]
    public struct UInt128Simple
    {
        public uint r0;
        public uint r1;
        public uint r2;
        public uint r3;

        public UInt128 ToUInt128()
        {
            UInt128.Create(out UInt128 c, r0, r1, r2, r3);

            return c;
        }

        public static UInt128Simple FromUInt128(UInt128 uInt128)
        {
            UInt128Simple c = new()
            {
                r0 = uInt128.r0,
                r1 = uInt128.r1,
                r2 = uInt128.r2,
                r3 = uInt128.r3
            };

            return c;
        }
        public static implicit operator UInt128Simple(UInt128 a)
        {
            return FromUInt128(a);
        }
    }
}
