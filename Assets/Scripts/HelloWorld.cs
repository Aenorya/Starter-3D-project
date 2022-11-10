using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Hello World from Windows XP";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
