using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextBlink : MonoBehaviour
{

	Text flashingText;

	// Use this for initialization
	void Start()
	{
		flashingText = GetComponent<Text>();
		StartCoroutine(BlinkText());
	}

	public IEnumerator BlinkText()
	{
		while (true)
		{
			flashingText.text = "";
			yield return new WaitForSeconds(.5f);
			flashingText.text = "시작하려면 아무키나 누르세요";
			yield return new WaitForSeconds(.5f);
		}
	}
}