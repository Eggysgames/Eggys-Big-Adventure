using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Saving : MonoBehaviour {

	public Rigidbody2D player;
	private int holder;
	private int eggyspawn; 

	private int world1eggs;
	private int world2eggs;
	private int world3eggs;
	private int world4eggs;
	private int world5eggs;
	private int world6eggs;
	private int world7eggs;
	private int world8eggs;
	private int world9eggs;
	private int world10eggs;
	private int world11eggs;
	private int world12eggs;
	private int world13eggs;
	private int world14eggs;
	private int world15eggs;
	private int world16eggs;
	private int world17eggs;
	private int world18eggs;
	private int world19eggs;
	private int world20eggs;
	private int world21eggs;
	private int world22eggs;
	private int world23eggs;

	public Text World1eggsText;
	public Text World2eggsText;
	public Text World3eggsText;
	public Text World4eggsText;
	public Text World5eggsText;
	public Text World6eggsText;
	public Text World7eggsText;
	public Text World8eggsText;
	public Text World9eggsText;
	public Text World10eggsText;
	public Text World11eggsText;
	public Text World12eggsText;
	public Text World13eggsText;
	public Text World14eggsText;
	public Text World15eggsText;
	public Text World16eggsText;
	public Text World17eggsText;
	public Text World18eggsText;
	public Text World19eggsText;
	public Text World20eggsText;
	public Text World21eggsText;
	public Text World22eggsText;
	public Text World23eggsText;

	public Transform spawn1;
	public Transform spawn2; 
	public Transform spawn3;
	public Transform spawn4;
	public Transform spawn5;
	public Transform spawn6;
	public Transform spawn7;
	public Transform spawn8;
	public Transform spawn9;
	public Transform spawn10;
	public Transform spawn11;
	public Transform spawn12;
	public Transform spawn13;
	public Transform spawn14;
	public Transform spawn15;
	public Transform spawn16;
	public Transform spawn17;
	public Transform spawn18;
	public Transform spawn19;
	public Transform spawn20;
	public Transform spawn21;
	public Transform spawn22;
	public Transform spawn23;
	public Transform spawn24;
	public Transform spawn25;
	public Transform spawn26;

	///////////////
	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject ebutton;

	private int controls; 

	public Text EggsNumberText; 
	public int currentEggs; 
	public int maxEggs = 460;

	void Start() {

		controls = PlayerPrefs.GetInt ("savedcontrols");

		if (controls == 1) {
			arrow1.GetComponent<SpriteRenderer> ().enabled = false;
			arrow2.GetComponent<SpriteRenderer> ().enabled = false;
			arrow3.GetComponent<SpriteRenderer> ().enabled = false;
			ebutton.GetComponent<SpriteRenderer> ().enabled = false;
			PlayerPrefs.SetInt ("savedcontrols", 1);
		}

		PlayerPrefs.SetInt ("savedcontrols", 1);

		PlayerPrefs.SetInt ("playonce", 1);

		player = player.GetComponent<Rigidbody2D>(); 

		////////////Set Position to door/////////////////

		eggyspawn = PlayerPrefs.GetInt ("spawn");

		if (eggyspawn == 1) {
			player.transform.position = spawn1.transform.position;
		}
		if (eggyspawn == 2) {
			player.transform.position = spawn2.transform.position;
		}
		if (eggyspawn == 3) {
			player.transform.position = spawn3.transform.position;
		}
		if (eggyspawn == 4) {
			player.transform.position = spawn4.transform.position;
		}
		if (eggyspawn == 5) {
			player.transform.position = spawn5.transform.position;
		}
		if (eggyspawn == 6) {
			player.transform.position = spawn6.transform.position;
		}
		if (eggyspawn == 7) {
			player.transform.position = spawn7.transform.position;
		}
		if (eggyspawn == 8) {
			player.transform.position = spawn8.transform.position;
		}
		if (eggyspawn == 9) {
			player.transform.position = spawn9.transform.position;
		}
		if (eggyspawn == 10) {
			player.transform.position = spawn10.transform.position;
		}
		if (eggyspawn == 11) {
			player.transform.position = spawn11.transform.position;
		}
		if (eggyspawn == 12) {
			player.transform.position = spawn12.transform.position;
		}
		if (eggyspawn == 13) {
			player.transform.position = spawn13.transform.position;
		}
		if (eggyspawn == 14) {
			player.transform.position = spawn14.transform.position;
		}
		if (eggyspawn == 15) {
			player.transform.position = spawn15.transform.position;
		}
		if (eggyspawn == 16) {
			player.transform.position = spawn16.transform.position;
		}
		if (eggyspawn == 17) {
			player.transform.position = spawn17.transform.position;
		}
		if (eggyspawn == 18) {
			player.transform.position = spawn18.transform.position;
		}
		if (eggyspawn == 19) {
			player.transform.position = spawn19.transform.position;
		}
		if (eggyspawn == 20) {
			player.transform.position = spawn20.transform.position;
		}
		if (eggyspawn == 21) {
			player.transform.position = spawn21.transform.position;
		}
		if (eggyspawn == 22) {
			player.transform.position = spawn22.transform.position;
		}
		if (eggyspawn == 23) {
			player.transform.position = spawn23.transform.position;
		}
		if (eggyspawn == 24) {
			player.transform.position = spawn24.transform.position;
		}
		if (eggyspawn == 25) {
			player.transform.position = spawn25.transform.position;
		}
		if (eggyspawn == 26) {
			player.transform.position = spawn26.transform.position;
		}

		//////////////////Loading Level Eggs/////////////////////
		world1eggs = PlayerPrefs.GetInt ("eggsfromlevel1");
		world2eggs = PlayerPrefs.GetInt ("eggsfromlevel2");
		world3eggs = PlayerPrefs.GetInt ("eggsfromlevel3");
		world4eggs = PlayerPrefs.GetInt ("eggsfromlevel4");
		world5eggs = PlayerPrefs.GetInt ("eggsfromlevel5");
		world6eggs = PlayerPrefs.GetInt ("eggsfromlevel6");
		world7eggs = PlayerPrefs.GetInt ("eggsfromlevel7");
		world8eggs = PlayerPrefs.GetInt ("eggsfromlevel8");
		world9eggs = PlayerPrefs.GetInt ("eggsfromlevel9");
		world10eggs = PlayerPrefs.GetInt ("eggsfromlevel10");
		world11eggs = PlayerPrefs.GetInt ("eggsfromlevel11");
		world12eggs = PlayerPrefs.GetInt ("eggsfromlevel12");
		world13eggs = PlayerPrefs.GetInt ("eggsfromlevel13");
		world14eggs = PlayerPrefs.GetInt ("eggsfromlevel14");
		world15eggs = PlayerPrefs.GetInt ("eggsfromlevel15");
		world16eggs = PlayerPrefs.GetInt ("eggsfromlevel16");
		world17eggs = PlayerPrefs.GetInt ("eggsfromlevel17");
		world18eggs = PlayerPrefs.GetInt ("eggsfromlevel18");
		world19eggs = PlayerPrefs.GetInt ("eggsfromlevel19");
		world20eggs = PlayerPrefs.GetInt ("eggsfromlevel20");
		world21eggs = PlayerPrefs.GetInt ("eggsfromlevel21");
		world22eggs = PlayerPrefs.GetInt ("eggsfromlevel22");
		world23eggs = PlayerPrefs.GetInt ("eggsfromlevel23");
		///1 is house1
		if (eggyspawn == 2) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world1eggs) {
				world1eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel1", world1eggs);
			}
		}
		if (eggyspawn == 3) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world2eggs) {
				world2eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel2", world2eggs);
			}
		}
		if (eggyspawn == 4) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world3eggs) {
				world3eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel3", world3eggs);
			}
		}
		if (eggyspawn == 5) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world4eggs) {
				world4eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel4", world4eggs);
			}
		}
		if (eggyspawn == 6) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world5eggs) {
				world5eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel5", world5eggs);
			}
		}
		if (eggyspawn == 7) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world6eggs) {
				world6eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel6", world6eggs);
			}
		}
		if (eggyspawn == 8) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world7eggs) {
				world7eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel7", world7eggs);
			}
		}
		if (eggyspawn == 9) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world8eggs) {
				world8eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel8", world8eggs);
			}
		}
		if (eggyspawn == 10) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world9eggs) {
				world9eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel9", world9eggs);
			}
		}
		if (eggyspawn == 11) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world10eggs) {
				world10eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel10", world10eggs);
			}
		}
		if (eggyspawn == 12) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world11eggs) {
				world11eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel11", world11eggs);
			}
		}
		if (eggyspawn == 13) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world12eggs) {
				world12eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel12", world12eggs);
			}
		}
		if (eggyspawn == 14) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world13eggs) {
				world13eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel13", world13eggs);
			}
		}
		if (eggyspawn == 15) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world14eggs) {
				world14eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel14", world14eggs);
			}
		}
		if (eggyspawn == 16) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world15eggs) {
				world15eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel15", world15eggs);
			}
		}
		if (eggyspawn == 17) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world16eggs) {
				world16eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel16", world16eggs);
			}
		}
		if (eggyspawn == 18) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world17eggs) {
				world17eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel17", world17eggs);
			}
		}
		if (eggyspawn == 19) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world18eggs) {
				world18eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel18", world18eggs);
			}
		}
		if (eggyspawn == 20) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world19eggs) {
				world19eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel19", world19eggs);
			}
		}
		if (eggyspawn == 21) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world20eggs) {
				world20eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel20", world20eggs);
			}
		}
		if (eggyspawn == 22) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world21eggs) {
				world21eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel21", world21eggs);
			}
		}
		if (eggyspawn == 23) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world22eggs) {
				world22eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel22", world22eggs);
			}
		}
		if (eggyspawn == 24) {
			holder = PlayerPrefs.GetInt ("holdeggs");
			if (holder > world23eggs) {
				world23eggs = holder;
				PlayerPrefs.SetInt ("eggsfromlevel23", world23eggs);
			}
		}
		///25 is house2
		World1eggsText.text = (world1eggs.ToString ()) + "/" + "20";
		World2eggsText.text = (world2eggs.ToString ()) + "/" + "20";
		World3eggsText.text = (world3eggs.ToString ()) + "/" + "20";
		World4eggsText.text = (world4eggs.ToString ()) + "/" + "20";
		World5eggsText.text = (world5eggs.ToString ()) + "/" + "20";
		World6eggsText.text = (world6eggs.ToString ()) + "/" + "20";
		World7eggsText.text = (world7eggs.ToString ()) + "/" + "20";
		World8eggsText.text = (world8eggs.ToString ()) + "/" + "20";
		World9eggsText.text = (world9eggs.ToString ()) + "/" + "20";
		World10eggsText.text = (world10eggs.ToString ()) + "/" + "20";
		World11eggsText.text = (world11eggs.ToString ()) + "/" + "20";
		World12eggsText.text = (world12eggs.ToString ()) + "/" + "20";
		World13eggsText.text = (world13eggs.ToString ()) + "/" + "20";
		World14eggsText.text = (world14eggs.ToString ()) + "/" + "20";
		World15eggsText.text = (world15eggs.ToString ()) + "/" + "20";
		World16eggsText.text = (world16eggs.ToString ()) + "/" + "20";
		World17eggsText.text = (world17eggs.ToString ()) + "/" + "20";
		World18eggsText.text = (world18eggs.ToString ()) + "/" + "20";
		World19eggsText.text = (world19eggs.ToString ()) + "/" + "20";
		World20eggsText.text = (world20eggs.ToString ()) + "/" + "20";
		World21eggsText.text = (world21eggs.ToString ()) + "/" + "20";
		World22eggsText.text = (world22eggs.ToString ()) + "/" + "20";
		World23eggsText.text = (world23eggs.ToString ()) + "/" + "20";

		///////////////Update Total Eggs////////////////////////////////////


		currentEggs = world1eggs + world2eggs + world3eggs + world4eggs + world5eggs + world6eggs + world7eggs + world8eggs + world9eggs + world10eggs + world11eggs + world12eggs + world13eggs + world14eggs + world15eggs + world16eggs + world17eggs + world18eggs + world19eggs + world20eggs + world21eggs + world22eggs + world23eggs;
		EggsNumberText.text = "" + currentEggs + "/" + maxEggs; 
		PlayerPrefs.SetInt("totaleggs", currentEggs);
		//PlayerPrefs.DeleteAll();
	}

}
