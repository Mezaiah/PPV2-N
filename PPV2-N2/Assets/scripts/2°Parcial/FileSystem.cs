using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Rendering;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    string positionS;
    bool IsSaving = false;
    void CreateFile()
    {
        //1) path
        string FileName = "Position";
        string extension = ".txt";
        string path = Application.dataPath + "/Resources/" + FileName + extension;

        //2)crear archivo si no existe ya uno con el mismo nombre
        if (!File.Exists(path))
        {
        //3)escribir dentro del archivo
            File.WriteAllText(path, "");
        }
        //4)Almacenar el contenido
        //string data = " Login Date: " + System.DateTime.Now + "\n" + positionS;
        string data = positionS;
        ////5)agregart la info al archivo
        File.AppendAllText(path, data);


    }
    string ReadFile(string _FileName, string _Extension)
    {
        
        string path = Application.dataPath + "/Resources/" + _FileName + _Extension;
        string data = "";
        if(File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
        return data;
    }

    Vector3 ReadPositionFromText(string _FileName, string _Extension)
    {
        string path = Application.dataPath + "/Resources/" + _FileName + _Extension;
        Vector3 position = Vector3.zero;

        if (File.Exists(path))
        {

            string data = File.ReadAllText(path);

           
            data = data.Replace("(", "").Replace(")", "");
            string[] components = data.Split(',');

            if (components.Length == 3)
            {
                float x, y, z;

                if (float.TryParse(components[0], out x) && float.TryParse(components[1], out y) && float.TryParse(components[2], out z))
                {
                    position = new Vector3(x, y, z);
                    return position;
                }
            }

            Debug.LogError("Failed to parse Vector3 from file data.");
        }
        else
        {
            Debug.LogError("File does not exist: " + path);
        }
        return position;
    }

    public void SaveP(Transform tr)
    {
        Vector3 position = obj.transform.position;
        positionS = position.ToString();
        Debug.Log(positionS);
    }
    // Start is called before the first frame update
    void Start()
    {
        string data = ReadFile("Position", ".txt");
        Debug.Log("Información de archivo: \n " + data);
        Vector3 position = ReadPositionFromText("Position", ".txt");
        Debug.Log("Position from file: " + position);
        obj2.transform.position = position;
    }

    //Update is called once per frame
    void Update()
    {
        //if (IsSaving)
        //{
            //SaveP(obj.transform);
            //CreateFile();
        //}
    }
}
