using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PeeScene : MonoBehaviour
{
    public GameObject PEE;
    public GameObject CHOICE_3;
    public GameObject CHOICE_2;
    [SerializeField] AudioSource Toilet;
    public GameObject textBox;
    [SerializeField] GameObject nextButton;
    public GameObject charMC;

    public void PeeButton()
    {
        StartCoroutine(Pee());
    }

    IEnumerator Pee()
    {
        CHOICE_2.SetActive(false);
        PEE.SetActive(true);
        Toilet.Play();
        yield return new WaitForSeconds(1);
        charMC.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        nextButton.SetActive(true);
    }

    public void NextButton()
    {
        PEE.SetActive(false);
        CHOICE_3.SetActive(true);
    }

}