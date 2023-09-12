using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_box_header_title : UI_box_Header
{
    public TMP_Text Title;
    // Start is called before the first frame update
    void Start()
    {
        Title = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
