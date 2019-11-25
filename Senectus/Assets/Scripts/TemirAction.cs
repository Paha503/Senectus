using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemirAction : MonoBehaviour
{
    private GameObject TemirDialog;
    private GameObject TemirDialog_Text1;
    private GameObject TemirDialog_Text2;
    // Start is called before the first frame update
    void Start()
    {
        TemirDialog.GameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D Temirlan) //Для 2D - в нашем случае, это событие выполняться не будет.
    {
        if (Input.GetKey(KeyCode.Z))
        {
            TemirDialog.Enabled - true;
            TemirDialog_Text2.Enabled = false;
        }
        if (TemirDialog.GameObject.SetActive(true))
        {
            if (Input.GetKey(KeyCode.X))
            {
                TemirDialog_Text1.Enabled = false;
                TemirDialog_Text2.Enabled - true;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
