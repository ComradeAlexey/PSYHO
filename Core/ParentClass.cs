using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PSYHO
{
    public abstract class ParentClass
    {
        string text;
        Text thisUIText;
        internal virtual void PrintText(){ }
        internal virtual void DeleteText() { }
        internal virtual void Dialog() { }
        internal virtual void NextStep() { }
        internal virtual void ClickOnAButton() { }
    }
}