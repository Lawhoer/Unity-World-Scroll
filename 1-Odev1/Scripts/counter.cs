using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counter : MonoBehaviour
{
    [SerializeField] int counterValue = 0;
    public static counter Counter;

    public TMP_Text tmpText;

    void Awake()
    {
        Counter = this;
    }

    public void InreaseCounter()
    {
        counterValue++;
        tmpText.text = counterValue.ToString();
    }
}
