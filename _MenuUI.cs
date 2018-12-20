using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _MenuUI : MonoBehaviour {

	public Button Play_Button;
	public Button Quit_Button;
	public Button InstructionsPG;

	void Start()
	{
		Button Playbtn = Play_Button.GetComponent<Button> ();
		Playbtn.onClick.AddListener (Playbtnclick);

		Button Quitbtn = Quit_Button.GetComponent<Button> ();
		Quitbtn.onClick.AddListener (Quitbtnclick);

		Button Instrbtn = InstructionsPG.GetComponent<Button> ();
		Instrbtn.onClick.AddListener (Instrbtnclick);
	}

	void Playbtnclick()
	{
		SceneManager.LoadScene (2);
	}

	void Quitbtnclick()
	{
		Application.Quit ();
	}

	void Instrbtnclick()
	{
		SceneManager.LoadScene (1);
	}
}
