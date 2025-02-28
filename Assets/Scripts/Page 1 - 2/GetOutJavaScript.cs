using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GetOutJavaScript : MonoBehaviour
{
    public GameObject charMC;
    public GameObject textBox;
    public GameObject CHOICE_1;
    public GameObject PAGE_2;
    public GameObject TAP_SCENE;
    [SerializeField] GameObject nextButton;

    public void GetOutJava()
    {
        StartCoroutine(GetOutScene());
        CHOICE_1.SetActive(false);
        PAGE_2.SetActive(true);
    }

    IEnumerator GetOutScene()
    {
        charMC.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        nextButton.SetActive(true);
    }

    public void NextButton()
    {
        PAGE_2.SetActive(false);
        TAP_SCENE.SetActive(true);
    }
}
