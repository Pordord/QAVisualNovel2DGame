using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GetOutBathroom : MonoBehaviour
{
    public GameObject charMC;
    public GameObject textBox;
    public GameObject CHOICE_3;
    public GameObject CHOICE_25;
    public GameObject PAGE_35;
    [SerializeField] GameObject nextButton;

    public void GetOutABathroomScene()
    {
        StartCoroutine(GetOutScene());
        CHOICE_3.SetActive(false);
        PAGE_35.SetActive(true);
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
        PAGE_35.SetActive(false);
        CHOICE_25.SetActive(true);
    }
}
