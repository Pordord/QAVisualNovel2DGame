using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TapScene : MonoBehaviour
{
    public GameObject TAP_SCENE;
    public GameObject PAGE_3;
    [SerializeField] AudioSource Beep;

    public void TapButton()
    {
        StartCoroutine(Tap());
    }

    IEnumerator Tap()
    {
        Beep.Play();
        yield return new WaitForSeconds(1);
        TAP_SCENE.SetActive(false);
        PAGE_3.SetActive(true);
    }

}