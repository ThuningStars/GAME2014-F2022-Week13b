using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject onScreenControls;
    public GameObject miniMap;

    // Start is called before the first frame update
    void Awake()
    {
        onScreenControls = GameObject.Find("OnScreenControls");

        onScreenControls.SetActive(Application.isMobilePlatform);

        miniMap = GameObject.Find("MiniMap");
        if(miniMap)
        {
            miniMap.SetActive(false);
        }
    }

    void Start()
    {
        //FindObjectOfType<SoundManager>().PlayMusic(Sound.MAIN_MUSIC);
    }

    void Update()
    {
        if((miniMap) && (Input.GetKeyDown(KeyCode.M)))
        {
            miniMap.SetActive(!miniMap.activeInHierarchy);
        }
    }
}
