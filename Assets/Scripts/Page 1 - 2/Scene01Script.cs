using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene01Script : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charMC;
    public GameObject textBox;
    public GameObject CHOICE_1;
    public GameObject PAGE_1;
    public GameObject MAINMENU;
    [SerializeField] AudioSource Yawn;
    [SerializeField] GameObject nextButton;

    public void Play()
    {
        MAINMENU.SetActive(false);
        PAGE_1.SetActive(true);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        fadeScreenIn.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeScreenIn.SetActive(false);
        charMC.SetActive(true);
        Yawn.Play();
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        nextButton.SetActive(true);
    }

    public void NextButton()
    {
        PAGE_1.SetActive(false);
        charMC.SetActive(false);
        textBox.SetActive(false);
        nextButton.SetActive(false);
        CHOICE_1.SetActive(true);
    }

}
