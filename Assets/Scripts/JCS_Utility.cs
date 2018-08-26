/**
 * $File: JCS_Utility.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *                   Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using System.Collections.Generic;


namespace JCSUnity
{
    /// <summary>
    /// All the utility function put here.
    /// </summary>
    public class JCS_Utility
        : MonoBehaviour
    {
        /// <summary>
        /// Pop the last value from the list.
        /// </summary>
        public static T ListPopFront<T>(List<T> list)
        {
            if (list.Count == 0)
                return default(T);

            T data = list[0];

            list.RemoveAt(0);

            return data;
        }

        /// <summary>
        /// Pop the last value from the list.
        /// </summary>
        public static T ListPopBack<T>(List<T> list)
        {
            if (list.Count == 0)
                return default(T);

            int lastIndex = list.Count - 1;

            T data = list[lastIndex];

            list.RemoveAt(lastIndex);

            return data;
        }
    }
}
