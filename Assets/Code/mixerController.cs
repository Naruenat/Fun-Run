using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class mixerController : MonoBehaviour {
	public AudioMixer audioMixer;

	[Space(10)]
	public Slider musicSlider;
	public Slider sfxSlider;

	public void SetMusicVolume(float volume){
		audioMixer.SetFloat ("musicVolume", volume);
	}

	public void SetSfxVolume(float volume){
		audioMixer.SetFloat ("sfxVolume", volume);
	}

	private void Start(){
		
		musicSlider.value = PlayerPrefs.GetFloat ("musicVolume", 0);
		sfxSlider.value = PlayerPrefs.GetFloat ("sfxVolume", 0);
	}

	private void OnDisable(){
		float musicVolume = 0;
		float sfxVolume = 0;

		audioMixer.GetFloat ("musicVolume", out musicVolume);
		audioMixer.GetFloat ("sfxicVolume", out sfxVolume);

		PlayerPrefs.SetFloat ("musixVolume", musicVolume);
		PlayerPrefs.SetFloat ("sfxVolume", sfxVolume);
		PlayerPrefs.Save ();
	}
}
