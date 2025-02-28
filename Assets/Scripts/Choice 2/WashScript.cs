using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashScript : MonoBehaviour
{
    [SerializeField] AudioSource Washing;
    [SerializeField] AudioSource Lights;
    public GameObject DEATH_SCENE;
    public GameObject WASH_DEATH;
    public GameObject CHOICE_3;
    public GameObject textBox;

    public void WashButton()
    {
        StartCoroutine(Wash());
    }

    IEnumerator Wash()
    {
        Washing.Play();
        yield return new WaitForSeconds(8);
        Lights.Play();
        yield return new WaitForSeconds(2);
        CHOICE_3.SetActive(false);
        WASH_DEATH.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(10);
        DEATH_SCENE.SetActive(true);
        WASH_DEATH.SetActive(false);
    }
}
