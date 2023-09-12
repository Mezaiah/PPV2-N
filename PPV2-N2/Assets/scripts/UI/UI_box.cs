using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_box : MonoBehaviour
{

    public UI_box_header_title BoxHeaderTitle;
    public string title = "";
    public string content = "";

    void Start()
    {
        BoxHeaderTitle.Title.text = title;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
