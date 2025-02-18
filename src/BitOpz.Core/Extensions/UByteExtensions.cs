﻿namespace BitOpz.Core.Extensions
{
    public static class UByteExtensions
    {
        #region Shift

        public static byte ShiftLeft(this byte value, int shift) => (byte)(value << shift);

        public static byte ShiftRight(this byte value, int shift) => (byte)(value >> shift);

        public static byte SignShiftLeft(this byte value, int shift) => (byte)(((value << shift) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignShiftRight(this byte value, int shift) => (byte)(((value & BitOpzConsts.BYTE_MASK_BITS) >> shift) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static byte RollLeft(this byte value, int shift) => (byte)((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift)));

        public static byte RollRight(this byte value, int shift) => (byte)((value >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift)));

        public static byte SignRollLeft(this byte value, int shift) => (byte)((((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignRollRight(this byte value, int shift) => (byte)(((((value & BitOpzConsts.BYTE_MASK_BITS) >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Roll

        #region Flip
        /* Let's be honest... this is a bit of a waste of time... */
        private static byte BitFlipEndian(this byte value) => (byte)((value << 4) | (value >> 4));

        #endregion Flip
    }
}
