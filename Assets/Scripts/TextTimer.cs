using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{

    public Text text;
    public float time = 3; //Seconds to read the text

    void Start()
    {
        text.CrossFadeAlpha(0.0f, 5f, false);
    }
}
