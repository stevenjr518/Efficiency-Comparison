using System;
using UnityEngine;

namespace Efficienct_Comparison
{
    public class Efficiency 
    {
        public delegate void MethodA();
        public static MethodA methodA;
        public delegate void MethodB();
        public static MethodB methodB;

        /// <summary>
        ///   <para>Compare two methods given by you and tell you which one is faster.</para>
        /// </summary>
        /// <param name="A">The first method.</param>
        /// <param name="B">The second method.</param>
        /// <param name="times">The running times of each method.</param>
        public static void Compare(MethodA A, MethodB B, int times) 
        {
#if UNITY_EDITOR
            TimeSpan A_Elapsted_Time;
            TimeSpan B_Elapsted_Time;
            if (A != null)
            {
                //Run A
                methodA += A;
                DateTime A_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    methodA();
                }
                DateTime A_End = DateTime.Now;
                A_Elapsted_Time = A_End - A_Start;
                Debug.Log("MethodA Spent " + A_Elapsted_Time);
                methodA -= A;
            }

            if (B != null)
            {
                //Run B
                methodB += B;
                DateTime B_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    methodB();
                }
                DateTime B_End = DateTime.Now;
                B_Elapsted_Time = B_End - B_Start;
                Debug.Log("MethodB Spent " + B_Elapsted_Time);
                methodB -= B;
            }

            if (A != null && B != null)
            {
                //Comparison
                if (A_Elapsted_Time > B_Elapsted_Time)
                {
                    Debug.Log("Method B is faster");
                }
                else if (A_Elapsted_Time < B_Elapsted_Time)
                {
                    Debug.Log("Method A is faster");
                }
                else
                {
                    Debug.Log("No different");
                }
            }

#endif
        }
    }
}
