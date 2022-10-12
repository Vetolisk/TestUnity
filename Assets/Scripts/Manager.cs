using System.Collections;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject TimeCreate;
    public GameObject CubePref;
    public float TimeCreateCube;
    void Start()
    {
        StartCoroutine(WaitAndPrint());
       
       
    }
    IEnumerator WaitAndPrint()
    {
        while (true)
        {
            if (TimeCreateCube!=0) {
                GameObject CloneCube = Instantiate(CubePref, new Vector3(0, 0.5f, 0), Quaternion.identity);
                Debug.Log(TimeCreateCube);
                yield return new WaitForSeconds(TimeCreateCube);
            }

            yield return null;
        }
    }
    public void SetText(string text)
    {
        if (text != "")
        {
            TimeCreateCube = float.Parse(text);
        }
    }
}
