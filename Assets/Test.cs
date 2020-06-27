using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Transform canvasTra;
    public Text text;
    private int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            //GameObject go = Instantiate(text.gameObject);
            //go.transform.localPosition = Vector3.zero;
            //go.transform.SetParent(canvasTra, false);
        }

        
        //text.rectTransform.sizeDelta = new Vector2(500f, 500f);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        //text.rectTransform.anchoredPosition = new Vector3(-365 + count, -121, 0);
        //text.rectTransform.sizeDelta = new Vector2(500 + count, 500f);
        text.text = count.ToString();
    }
}
