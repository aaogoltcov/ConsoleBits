using System.Buffers.Binary;

namespace ConsoleBits;

public class Bits
{
    public byte Value { get; private set; } = 0;

    public Bits(byte byteValue)
    {
        this.Value = byteValue;
    }
    
    public static explicit operator Bits(byte byteValue) => new Bits(byteValue);
    public static explicit operator Bits(int intValue) => new Bits(BitConverter.GetBytes(intValue)[0]);
    public static explicit operator Bits(long longValue) => new Bits(BitConverter.GetBytes(longValue)[0]);
}