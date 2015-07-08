using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spriteManager : MonoBehaviour {

	public Sprite muteAudioSprite;
	public Sprite unmuteAudioSprite;

	private Button button;

	private SpriteRenderer spriteRenderer;

	public bool muteAudio;

	void Start()
	{	
		button = GetComponent<Button>();

//		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
//
//		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
//			spriteRenderer.sprite = unmuteAudioSprite; // set the sprite to sprite1
	}
		
	void Update()
	{
		if (!muteAudio) {
			//spriteRenderer.sprite = unmuteAudioSprite;
			button.image.sprite = unmuteAudioSprite;
		} else if (muteAudio) {
			//spriteRenderer.sprite = muteAudioSprite;
			button.image.sprite = muteAudioSprite;
		}
	}
}
