using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Mainmenucode : MonoBehaviour {


	public Animator FadingOut; 
	public Animator FadingIn; 

	private bool beginlevel;
	private bool beginlevel2;
	private int timer;
	private int timer2;

	public int once; 

	public int introtimer = 0; 

	public AudioSource Cursorselect;

    public Text continuetext;
    private int saveholder;
    private string GrabSceneName;

    void Start () {

		once = PlayerPrefs.GetInt ("playonce");
		Time.timeScale = 1f;
		beginlevel = false;
        timer = 0;

        GrabSceneName = SceneManager.GetActiveScene().name;


        if (GrabSceneName == "_MainMenu") {
            saveholder = PlayerPrefs.GetInt("eggsfromlevel1");

            if (saveholder == 0) {
                continuetext.GetComponent<Text>().canvasRenderer.SetAlpha(0.09f);
                continuetext.GetComponent<Button>().interactable = false;
            }
        }

    }



	void Update () {

		introtimer++; 

		if (beginlevel == true) {
			timer++; 
		}
		if (timer > 120) {
			SceneManager.LoadScene ("Cutscene"); 
		}

		if (beginlevel2 == true) {
			timer2++; 
		}
		if (timer2 > 120) {
			SceneManager.LoadScene ("Home"); 
		}

		//Right Click
		if (Input.GetMouseButtonDown (1)) {
			Application.ExternalEval("http://www.eggysgames.com");
		}


	}


	public void startgame() {
		FadingOut.SetTrigger ("mytrigger2");
		beginlevel = true; 
	}
	public void continuegame() {
		if (once == 1) {
			FadingOut.SetTrigger ("mytrigger2");
			beginlevel2 = true; 
		}
	}
	public void skipbutton() {
		FadingOut.SetTrigger ("mytrigger2");
		beginlevel2 = true; 
	}
	public void eggysgames() {
		Application.ExternalEval("window.open(\"http://www.eggysgames.com\",\"_blank\")");
	}
	public void playmoregames() {
		Application.ExternalEval("window.open(\"http://armor.ag/MoreGames\",\"_blank\")");
	}
	public void Likeus() {
		Application.ExternalEval("window.open(\"http://www.facebook.com/ArmorGames\",\"_blank\")");
	}
	public void GooglePlay() {
		Application.ExternalEval("window.open(\"https://play.google.com/store/apps/details?id=com.EggysGames.EggysBigAdventure2\",\"_blank\")");
	}
	public void DeleteSaveData() {
        PlayerPrefs.DeleteAll();
        continuetext.GetComponent<Text>().canvasRenderer.SetAlpha(0.09f);
        continuetext.GetComponent<Button>().interactable = false;
    }
	public void sound() {
		Cursorselect.Play ();
	}

}
