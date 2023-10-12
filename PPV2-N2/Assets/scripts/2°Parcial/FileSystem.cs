using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    string positionS;
    void CreateFile()
    {
        //1) path
        string FileName = "example";
        string extension = ".txt";
        string path = Application.dataPath + "/Resources/" + FileName + extension;

        //2)crear archivo si no existe ya uno con el mismo nombre
        if (!File.Exists(path))
        {
        //3)escribir dentro del archivo
            File.WriteAllText(path, "hola" + "\n");
        }
        //4)Almacenar el contenido
        string data = " Login Date: " + System.DateTime.Now + "\n" + positionS;
        //5)agregart la info al archivo
        File.AppendAllText(path, data);
        

    }

    public void SaveP(Transform tr)
    {
        Vector3 position = obj.transform.position;
        positionS = "el Objeto se encuentra en: " + position.ToString();
        Debug.Log(positionS);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SaveP(obj.transform);
        CreateFile();
        
    }
}
