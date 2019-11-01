using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TooltipScript : MonoBehaviour {

    public Text helpText;
    public Text tooltipText;
    public Text hiText;
    public RawImage mcImage;

    public string helpString;
    public string tooltipString;
    public string hiString;
    public RawImage mcPic;
    

    
	
	void Start () 
    {
        helpText = GameObject.Find("HelpText").GetComponent<Text>();
        tooltipText = GameObject.Find("TooltipText").GetComponent<Text>();
        hiText = GameObject.Find("HiText").GetComponent<Text>();
        mcImage.enabled = false;
    }
	
	
	void Update () {
		
	}

    void OnVREnter() {
        helpText.text = helpString;
        tooltipText.text = tooltipString;
        hiText.text = hiString;
        mcImage.enabled = true;
    }
    void OnVRExit() {
        helpText.text = " ";
        tooltipText.text = " ";
        hiText.text = " ";
        mcImage.enabled = false;
        
        
        
    }

    void OnVRTriggerDown()
    {

        StartCoroutine(LoadYourAsyncScene());
    }

    

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MenuScene");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


}
