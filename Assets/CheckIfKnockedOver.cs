using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckIfKnockedOver : MonoBehaviour
{
    public TMP_Text knockedOverText;
    private bool isStanding = true;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.up.y<0.5f && isStanding) { //https://discussions.unity.com/t/detect-falling-over-in-bowling/28711
            isStanding = false;
		    InitialSetup.knockedOver++;
			knockedOverText.text = "Knocked Over: " + InitialSetup.knockedOver.ToString();
		}
    }
}
