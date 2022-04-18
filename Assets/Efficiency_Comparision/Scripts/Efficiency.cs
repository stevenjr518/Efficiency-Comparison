using System;
using UnityEngine;

namespace Efficienct_Comparison
{
    public class Efficiency 
    {
        public delegate void MethodA();
        public static MethodA s_MethodA;
        public delegate void MethodB();
        public static MethodB s_MethodB;

        /// <summary>
        ///   <para>Compare two methods given by you and tell you which one is faster.</para>
        /// </summary>
        /// <param name="a">The first method.</param>
        /// <param name="b">The second method.</param>
        /// <param name="times">The running times of each method.</param>
        public static void Compare(MethodA a, MethodB b, int times) 
        {
#if UNITY_EDITOR
            TimeSpan a_Elapsted_Time;
            TimeSpan b_Elapsted_Time;
            if (a != null)
            {
                //Run A
                s_MethodA += a;
                DateTime a_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    s_MethodA();
                }
                DateTime a_End = DateTime.Now;
                a_Elapsted_Time = a_End - a_Start;
                Debug.Log("MethodA Spent " + a_Elapsted_Time);
                s_MethodA -= a;
            }

            if (b != null)
            {
                //Run B
                s_MethodB += b;
                DateTime b_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    s_MethodB();
                }
                DateTime b_End = DateTime.Now;
                b_Elapsted_Time = b_End - b_Start;
                Debug.Log("MethodB Spent " + b_Elapsted_Time);
                s_MethodB -= b;
            }

            if (a != null && b != null)
            {
                //Comparison
                if (a_Elapsted_Time > b_Elapsted_Time)
                {
                    Debug.Log("Method B is faster");
                }
                else if (a_Elapsted_Time < b_Elapsted_Time)
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
