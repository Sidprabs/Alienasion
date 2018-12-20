using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public Transform canvas;
	public Button Play_Button;
	public Button Quit_Button;

	void Start()
	{
		Button Playbtn = Play_Button.GetComponent<Button> ();
		Playbtn.onClick.AddListener (Playbtnclick);

		Button Quitbtn = Quit_Button.GetComponent<Button> ();
		Quitbtn.onClick.AddListener (Quitbtnclick);

	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive(true);
				Time.timeScale = 0;
			} else
			{
				canvas.gameObject.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}
	void Playbtnclick()
	{
		SceneManager.LoadScene (2);
	}

	void Quitbtnclick()
	{
		Application.Quit ();
	}
}
