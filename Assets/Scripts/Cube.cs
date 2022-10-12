using UnityEngine;

public class Cube : MonoBehaviour
{

    Vector3 movement;
    public float Speed=0.5f;
    public float Distance=1;


    private void Start()
    {
        movement = new Vector3(0, 0, 1);
    }

    private void MovementLogic()
    {
        
        transform.Translate(movement * Speed*Time.fixedDeltaTime);
    }
    private void Update()
    {
        
            MovementLogic();
          
            if (transform.position.z >= Distance)
            {
                Destroy(gameObject);
            }

        
    }
    public void ChangeSetTextSpeed(string text)
    {
        if (text != "")
        {
            Speed = float.Parse(text);
        }
    }
    public void ChangeSetTextDictance(string text)
    {
        if (text != "")
        {
            Distance = float.Parse(text);
        }
    }

}
