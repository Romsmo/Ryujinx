﻿namespace ARMeilleure.Decoders
{
    class OpCode32SimdRev : OpCode32SimdCmpZ
    {
        public OpCode32SimdRev(InstDescriptor inst, ulong address, int opCode) : base(inst, address, opCode)
        {
            // Currently, this instruction is treated as though it's OPCODE is the true size,
            // which lets us deal with reversing vectors on a single element basis (eg. math magic an I64 rather than insert lots of I8s).
            int tempSize = Size;
            Size = 3 - Opc; // Op 0 is 64 bit, 1 is 32 and so on.
            Opc = tempSize;
        }
    }
}
