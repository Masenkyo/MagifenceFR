using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUI : MonoBehaviour
{
    public HPGate hp;
    public Text HPText;
    
    void Start()
    {
        
    }
    void Update()
    {
        HPText.text = hp.hp.ToString();
    }
}
