/**
 * $File: JCS_GUIObject.cs $
 * $Date: 2018-08-25 22:33:57 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright © 2018 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace JCSUnity
{
    /// <summary>
    /// Cross Unity's GUI system object.
    /// </summary>
    public class JCS_GUIObject
        : MonoBehaviour
    {

        /*******************************************/
        /*            Public Variables             */
        /*******************************************/

        /*******************************************/
        /*           Private Variables             */
        /*******************************************/

        /*******************************************/
        /*           Protected Variables           */
        /*******************************************/

        [Header("** Check Variables (JCS_UndoRedoComponent) **")]

        [Tooltip("Input Field component.")]
        [SerializeField]
        protected InputField mInputField = null;

        [Tooltip("Slider component.")]
        [SerializeField]
        protected Slider mSlider = null;

        [Tooltip("Toggle component.")]
        [SerializeField]
        protected Toggle mToggle = null;

        [Tooltip("Dropdown component.")]
        [SerializeField]
        protected Dropdown mDropdown = null;

        [Tooltip("Scrollbar component.")]
        [SerializeField]
        protected Scrollbar mScrollBar = null;


        [Header("** Runtime Variables (JCS_UndoRedoComponent) **")]

        [Tooltip("GUI type.")]
        [SerializeField]
        protected JCS_GUIType mGUIType = JCS_GUIType.NONE;

        /*******************************************/
        /*             setter / getter             */
        /*******************************************/
        public JCS_GUIType GUIType { get { return this.mGUIType; } set { this.mGUIType = value; } }
        public InputField inputField { get { return this.mInputField; } }
        public Slider slider { get { return this.mSlider; } }
        public Toggle toggle { get { return this.mToggle; } }
        public Dropdown dropdown { get { return this.mDropdown; } }
        public Scrollbar scrollbar { get { return this.mScrollBar; } }

        /*******************************************/
        /*            Unity's function             */
        /*******************************************/
        protected virtual void Awake()
        {
            UpdateGUIData();
        }

        /*******************************************/
        /*              Self-Define                */
        /*******************************************/
        //----------------------
        // Public Functions

        /// <summary>
        /// Update the GUI data.
        /// </summary>
        public virtual void UpdateGUIData()
        {
            switch (mGUIType)
            {
                case JCS_GUIType.INPUT_FIELD:
                    {
                        this.mInputField = this.GetComponent<InputField>();
                    }
                    break;

                case JCS_GUIType.DROP_DOWN:
                    {
                        this.mDropdown = this.GetComponent<Dropdown>();
                    }
                    break;

                case JCS_GUIType.SLIDER:
                    {
                        this.mSlider = this.GetComponent<Slider>();
                    }
                    break;

                case JCS_GUIType.SCROLL_BAR:
                    {
                        this.mScrollBar = this.GetComponent<Scrollbar>();
                    }
                    break;

                case JCS_GUIType.TOGGLE:
                    {
                        this.mToggle = this.GetComponent<Toggle>();
                    }
                    break;
            }
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

    }
}
