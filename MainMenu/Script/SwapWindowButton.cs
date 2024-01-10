using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWindowButton : CustomButtonUI
{
    [SerializeField] GameObject toHide = null;
    [SerializeField] GameObject toShow = null;
    [SerializeField] bool onlyCloseWindow = false;


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
        toHide.SetActive(false);
        if (onlyCloseWindow) return;
        toShow.SetActive(true);
    }
}
