using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sound_controll : MonoBehaviour
{
    public static bool sound = true;
    public static bool music = true;
    public GameObject sound_off_obj;
    public GameObject sound_on_obj;
    public GameObject music_off_obj;
    public GameObject music_on_obj;

    // Start is called before the first frame update
    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("background");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sound_on()
    {
        sound = true;
        FindObjectOfType<AudioManager>().MuteSound("click");
        FindObjectOfType<AudioManager>().Play("click");
        sound_on_obj.SetActive(true);
        sound_off_obj.SetActive(false);
    }

    public void music_on()
    {
        music = true;
        FindObjectOfType<AudioManager>().MuteSound("background");//
        FindObjectOfType<AudioManager>().Play("click");
        music_on_obj.SetActive(true);
        music_off_obj.SetActive(false);
    }

    public void M_Sound()
	{
		FindObjectOfType<AudioManager>().MuteSound("click");//
        sound = false;
        sound_on_obj.SetActive(false);
        sound_off_obj.SetActive(true);
    }
	public void M_Music()
	{
		FindObjectOfType<AudioManager>().MuteSound("background");
        music = false;
        music_on_obj.SetActive(false);
        music_off_obj.SetActive(true);
    }
}
