using System;
using UnityEngine;

namespace Efficienct_Comparison
{
    public class Efficiency 
    {
        public delegate void Method();
        public static Method MethodA;
        public static Method MethodB;

        /// <summary>
        ///   <para>Compare two methods given by you and tell you which one is faster.</para>
        /// </summary>
        /// <param name="a">The first method.</param>
        /// <param name="b">The second method.</param>
        /// <param name="times">The running times of each method.</param>
        public static void Compare(Method a, Method b, int times) 
        {
#if UNITY_EDITOR
            TimeSpan a_Elapsted_Time;
            TimeSpan b_Elapsted_Time;
            if (a != null)
            {
                //Run A
                MethodA += a;
                DateTime a_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    MethodA();
                }
                DateTime a_End = DateTime.Now;
                a_Elapsted_Time = a_End - a_Start;
                Debug.Log("MethodA Spent " + a_Elapsted_Time);
                MethodA -= a;
            }

            if (b != null)
            {
                //Run B
                MethodB += b;
                DateTime b_Start = DateTime.Now;
                for (int i = 0; i <= times; ++i)
                {
                    MethodB();
                }
                DateTime b_End = DateTime.Now;
                b_Elapsted_Time = b_End - b_Start;
                Debug.Log("MethodB Spent " + b_Elapsted_Time);
                MethodB -= b;
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
