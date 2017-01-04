﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace g3
{
    public class Util
    {

		static public void gBreakToDebugger() {
			if ( System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();
		}

        static public void gDevAssert(bool bValue) {
            if (bValue == false)
                throw new Exception("gDevAssert");
        }
	
	
        // useful in some cases
        public static bool IsRunningOnMono ()
        {
            return Type.GetType ("Mono.Runtime") != null;
        }


        static public bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }
        static public bool IsBitSet(int n, int pos)
        {
            return (n & (1 << pos)) != 0;
        }



        static public float[] BufferCopy(float[] from, float[] to)
        {
            if (from == null)
                return null;
            if (to.Length != from.Length)
                to = new float[from.Length];
            Buffer.BlockCopy(from, 0, to, 0, from.Length * sizeof(float));
            return to;
        }
        static public int[] BufferCopy(int[] from, int[] to)
        {
            if (from == null)
                return null;
            if (to.Length != from.Length)
                to = new int[from.Length];
            Buffer.BlockCopy(from, 0, to, 0, from.Length * sizeof(int));
            return to;
        }


    }
}
