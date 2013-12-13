using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        // Fields
        private ulong bitsContainer;

        // Properties
        public ulong BitsContainer
        { 
            get 
            { 
                return this.bitsContainer;
            }
            
            private set
            {
                this.bitsContainer = value;
            } 
        }
        
        // Constructor
        public BitArray64(dynamic number)
        {
            string bitsRepresentation = Convert.ToString(number, 2).PadLeft(64, '0');
            this.BitsContainer = ulong.Parse(bitsRepresentation);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }
                //else if ((this.BitsContainer / (ulong)(Math.Pow(10, index))) < 1)
                //{
                //    //throw new IndexOutOfRangeException("No such index");
                //    return 0;
                //}
                else
                {
                    // Finds bit by its index
                    return (int)(this.BitsContainer / (ulong)(Math.Pow(10, index)) % 10);
                }
            }
        }


        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }

        //    BitArray64 bitArray64 = obj as BitArray64;
        //    if (bitArray64 == null)
        //    {
        //        return false;
        //    }

        //    return this.Bits == bitArray64.Bits;
        //}

        //public override int GetHashCode()
        //{
        //    return this.Bits.GetHashCode();
        //}

        //public static bool operator ==(BitArray64 bitArray64A, BitArray64 bitArray64B)
        //{
        //    return BitArray64.Equals(bitArray64A, bitArray64B);
        //}

        //public static bool operator !=(BitArray64 bitArray64A, BitArray64 bitArray64B)
        //{
        //    return !BitArray64.Equals(bitArray64A, bitArray64B);
        //}

        public override string ToString()
        {
            return string.Format("Bits as follows:\n{0, 64:D64}", this.BitsContainer);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 19; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<int>).GetEnumerator();
        }
    }
}
