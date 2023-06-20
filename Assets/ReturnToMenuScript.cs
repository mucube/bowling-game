using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuScript : MonoBehaviour
{
    public void ReturnToMenu() {
        SceneManager.LoadScene("StartMenu");
    }
}
