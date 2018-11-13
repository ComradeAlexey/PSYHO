using UnityEngine;
using UnityEngine.UI;
namespace PSYHO
{
    public class ChildClass : ParentClass
    {
        public int buttonNumber;//номер нажатой кнопки, 1 или 2(если не была нажата то 0)
        public bool readinessToButtonPressed;//была ли нажата кнопка?
        public static void NewStandartDialogMaintText(out ChildClass childClass, Text _UIText, string text, ref int step , ref bool nextStep, ref bool startPrintingMainText, ref bool endPrintingMainText, ref bool startDeletingMainText, ref bool endDeletingMainText)
        {
            StandartDialogMainText standartDialogMainText = new StandartDialogMainText(_UIText,text , ref step, ref nextStep, ref startPrintingMainText, ref endPrintingMainText, ref startDeletingMainText, ref endDeletingMainText);
            childClass = standartDialogMainText;
        }

        internal override void Dialog()
        {
            
        }

        public static void BaseOfPrintingStandartDialog(ref Text _UIText, string text, ref bool StatePrinting)
        {
            if (_UIText.text.Length < text.Length)
            {
                _UIText.text += text[_UIText.text.Length];
            }
            else
            {
                StatePrinting = true;
            }
        }

        public static void BaseOfDeletingStandartDialog(ref Text _UIText, ref bool StateDeleting)
        {
            if (_UIText.text.Length > 0)
            {
                _UIText.text = _UIText.text.Remove(_UIText.text.Length - 1);
            }
            else
            {
                StateDeleting = true;
            }
        }
    }
    public class StandartDialogMainText : ChildClass
    {
        bool nextStep;
        bool startPrintingMainText;
        bool endPrintingMainText;
        bool startDeletingMainText;
        bool endDeletingMainText;
        bool ClickOnButton;
        int step;
        readonly string text;
        Text _UIText;

        public StandartDialogMainText(Text _UIText, string text,ref int step, ref bool nextStep, ref bool startPrintingMainText, ref bool endPrintingMainText, ref bool startDeletingMainText, ref bool endDeletingMainText)
        {
            this.text = text;
            this._UIText = _UIText;
            this.nextStep = nextStep;
            this.startPrintingMainText = startPrintingMainText;
            this.startDeletingMainText = startDeletingMainText;
            this.endPrintingMainText = endPrintingMainText;
            this.endDeletingMainText = endDeletingMainText;
            this.step = step;
        }

        internal override void PrintText()
        {
            Debug.Log("endPrintingMainText = " + endPrintingMainText);
            if (!endPrintingMainText)
            {
                BaseOfPrintingStandartDialog(ref _UIText, text, ref endPrintingMainText);
            }
        }

        internal override void DeleteText()
        {
            if(readinessToButtonPressed)
            {
                BaseOfDeletingStandartDialog(ref _UIText, ref endPrintingMainText);
            }
        }
        internal override void NextStep()
        {
            if (!nextStep && endDeletingMainText)
            {
                step++;
                nextStep = true;
            }
        }

        internal override void Dialog()
        {
            PrintText();
            DeleteText();
            NextStep();
        }
    }
}