using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 target;
    public float speed = 5f;

    // Called when a script is enabled
    void Start()
    {
        target = transform.position;
        LeanTween.scale(gameObject, new Vector3(115, 115, 115), 0.8f).setEaseLinear().setLoopPingPong();
    }

    // Called once every frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            if (mousePos.y < 1000 && mousePos.y > 77 && mousePos.x < 1800 && mousePos.x > 100)
            {
                target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
                target.y = transform.position.y;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, target, Random.Range(speed,speed * 5) * Time.deltaTime);
    }


}
