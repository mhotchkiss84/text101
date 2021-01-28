using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This allows for use in unity right click to create
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //Text area sets size of text field in Unity. First = min Second = amount of lines before scroll
    [TextArea(14,10)] [SerializeField] string StoryText;
}
