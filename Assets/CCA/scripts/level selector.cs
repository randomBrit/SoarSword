using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadLevel : MonoBehaviour
{
    public TMP_Dropdown dd;

    public void valueChanged()
    {
        switch (dd.value)
        {
            case 1:
                SceneManager.LoadScene("Scene 1");
                break;
            case 2:
                SceneManager.LoadScene("Scene 2");
                break;
        }
    }
}