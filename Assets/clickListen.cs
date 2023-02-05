using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class clickListen : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    public GameObject menus;
    public GameObject cover;
    public float smooth = 5f;
    public GameObject canva;
    public GameObject camera;
    private bool is_true_camera = false;
    private bool end = false;
    public float  delei_of_camera = 1;
    GameObject book;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
		Vector3 end_posetion = new Vector3(-0.14f, 6.945f, 2.79f);
        if (is_true_camera == false)
        {
            is_true_camera = true;
            LeanTween.moveLocal(camera, end_posetion, delei_of_camera)
            .setEaseLinear().setOnComplete(() => { end = true; });
            LeanTween.rotateLocal(camera, new Vector3(20, 4.91f, camera.transform.rotation.y), delei_of_camera)
            .setEaseLinear(); // one set complete
            menus.SetActive(false);
            //StartCoroutine("delai_camera");
        }
	}

    IEnumerator delai()
    {
        while (cover.transform.rotation.eulerAngles.y <=  11 || cover.transform.rotation.eulerAngles.y >= 180)
        {
            
            cover.transform.Rotate(Vector3.down, smooth * Time.deltaTime);
            yield return new WaitForSeconds(0.01f);
        }
        end = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_true_camera == true && end == true)
            StartCoroutine("delai");
        else if (Input.GetKeyUp("space") && end == false)
        {
            book = canva.transform.GetChild(0).gameObject;
            book.GetComponent<AutoFlip>().FlipRightPage();
        }
    }
}
