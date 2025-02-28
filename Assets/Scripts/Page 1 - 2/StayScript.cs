using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StayScript : MonoBehaviour
{
    public GameObject CHOICE_1;
    public GameObject JAVA_DEATH;
    public GameObject DEATH_SCENE;
    public GameObject textBox;

    public void Stay()
    {
        StartCoroutine(JavaDeathScene());
    }

    IEnumerator JavaDeathScene()
    {
        JAVA_DEATH.SetActive(true);
        yield return new WaitForSeconds(3);
        CHOICE_1.SetActive(false);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(10);
        DEATH_SCENE.SetActive(true);
        JAVA_DEATH.SetActive(false);
    }

}