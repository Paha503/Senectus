using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    public AudioClip CharacterTheme;

    void Start()
    {
        TemirDialog.GameObject.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(CharacterTheme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
