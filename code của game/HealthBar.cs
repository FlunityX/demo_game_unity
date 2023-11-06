using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    public Image Fillbar ;
    public TextMeshProUGUI valueText;
    public void UpdateBar(int currentValue, int maxValue )
    {
        Fillbar.fillAmount =(float)currentValue/ (float) maxValue;
        valueText.text = currentValue.ToString()+" / "+maxValue.ToString(); 
    }
    
}
