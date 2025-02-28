using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02 : MonoBehaviour
{
    public GameObject charMC;
    public GameObject textBox;
    public GameObject CHOICE_2;
    public GameObject PAGE_3;
    [SerializeField] GameObject nextButton;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        charMC.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        nextButton.SetActive(true);
    }

    public void NextButton()
    {
        PAGE_3.SetActive(false);
        CHOICE_2.SetActive(true);
    }
}
