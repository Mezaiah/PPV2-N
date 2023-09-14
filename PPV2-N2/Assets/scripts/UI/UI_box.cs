using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_box : MonoBehaviour
{
    private UI_box_BG BoxBG;
    private UI_box_Header BoxHeader;
    private UI_box_header_title BoxHeaderTitle;
    private UI_box_container_Title BoxContent;

    public string title = "";
    public string content = "";
   
    public bool HasCloseBtn = true;
    void Start()
    {
        BoxBG = transform.GetChild(0).GetComponent<UI_box_BG>();
        BoxHeader = transform.GetChild(0).transform.GetChild(0).GetComponent<UI_box_Header>();
        BoxHeaderTitle = transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<UI_box_header_title>();
        BoxContent = transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).GetComponent<UI_box_container_Title>();
        BoxHeaderTitle.Title.text = title;
        BoxContent.content.text = content;
        

        transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(HasCloseBtn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
