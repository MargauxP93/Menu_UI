using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : CustomButtonUI
{
    [SerializeField] string sceneName = "";
    [SerializeField] SceneAsset sceneToLoad = null;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Execute()
    {        
        //SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene(sceneToLoad.name);
    }
}
