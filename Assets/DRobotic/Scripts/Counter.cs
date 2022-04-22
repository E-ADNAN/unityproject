using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public Text m_Text;
    public int m_Count;

    private void OnTriggerEnter(Collider other)
    {
        if(string.Equals(other.name,"SpawningCube(Clone)"))
        m_Text.text = (++m_Count).ToString();

    }
}
