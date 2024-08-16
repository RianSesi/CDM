using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NewBehaviourScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject menuOpcoes;
    public GameObject telaInicial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            videoPlayer.Play();
            menuOpcoes.SetActive(true);
            telaInicial.SetActive(false);
        }
        
    }
}
