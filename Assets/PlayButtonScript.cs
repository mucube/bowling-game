using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayButtonScript : MonoBehaviour
{
    public TMP_Dropdown chooseMode;
    public void Play() {
        int mode = chooseMode.value;
        
        if (mode == 0) {
            SceneManager.LoadScene("TenPin");
        }
        if (mode == 1) {
            SceneManager.LoadScene("FivePin");
        }
        if (mode == 2) {
            SceneManager.LoadScene("NinePin");
        }
    }
}
