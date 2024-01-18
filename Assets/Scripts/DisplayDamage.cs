using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageCanvas;
    [SerializeField] float displayTime;

    void Start()
    {
        damageCanvas.enabled = false;
    }

    public void ShowDamageCanvas()
    {
        StartCoroutine(DisplayDamageCanvas());
    }

    IEnumerator DisplayDamageCanvas()
    {
        damageCanvas.enabled = true;
        yield return new WaitForSeconds(displayTime);
        damageCanvas.enabled = false;
    }
}
