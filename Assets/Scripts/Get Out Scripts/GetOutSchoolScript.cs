using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GetOutSchoolScript : MonoBehaviour
{
    public GameObject textBox;
    public GameObject GETOUT_ENDING;
    public GameObject CHOICE_25;
    public GameObject CHOICE_2;
    public GameObject Stairs;
    public GameObject School;
    public GameObject THANKYOUFORPLAYING;

    public void GetOutSchool()
    {
        StartCoroutine(GetOutEnding());
        CHOICE_25.SetActive(false);
        CHOICE_2.SetActive(false);
    }

    IEnumerator GetOutEnding()
    {
        GETOUT_ENDING.SetActive(true);
        Stairs.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(5);
        Stairs.SetActive(false);
        School.SetActive(true);
        yield return new WaitForSeconds(5);
        School.SetActive(false);
        THANKYOUFORPLAYING.SetActive(true);
        GETOUT_ENDING.SetActive(false);
    }

}
