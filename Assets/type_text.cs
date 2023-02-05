using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class type_text : MonoBehaviour
{
    public TMP_Text text;
    public string[] sentences;
    public float delay = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (string sentence in sentences)
        {
            text.text = "";
            yield return new WaitForSeconds(delay);
            yield return new WaitForSeconds(delay);
            foreach (char letter in sentence.ToCharArray())
            {
                text.text += letter;
                yield return new WaitForSeconds(delay);
            }
            yield return new WaitForSeconds(delay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
