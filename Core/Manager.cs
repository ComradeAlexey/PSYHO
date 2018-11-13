using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PSYHO
{
    public class Manager : MonoBehaviour
    {
        public enum WorkMode
        {
            standart
        }
        public ChildClass childClass;
        public Text mainText;
        public bool nextStep;
        public bool startPrintingMainText;
        public bool endPrintingMainText;
        public bool startDeletingMainText;
        public bool endDeletingMainText;
        public int step = 0;
        void Start()
        {

        }
        void Update()
        {
            if(nextStep)
            {
                ChildClass.NewStandartDialogMaintText(out childClass, mainText,Text_RU.MainText[step], ref step, ref nextStep, ref startPrintingMainText, ref endPrintingMainText, ref startDeletingMainText, ref endDeletingMainText);
                Debug.Log("childClass = " + childClass);
                nextStep = false;
            }
            if (!nextStep & childClass != null)
            {
                childClass.Dialog();
            }
        }
    }
}
