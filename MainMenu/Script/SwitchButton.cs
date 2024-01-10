using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : CustomButtonUI
{
    [SerializeField] GameObject toShow = null;
    public GameObject ToShow => toShow;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Init), 0.1f); // met un délai pour l'appel
    }

    void DelayedInit()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    protected override void Execute()
    {
        toShow.SetActive(true);
        Debug.Log("Execute");
    }
}
