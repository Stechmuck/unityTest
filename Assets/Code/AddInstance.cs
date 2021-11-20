using UnityEngine;

public class AddInstance : MonoBehaviour
{
    public GameObject korGE;
    public static int n = 0;

    public void OnButtonPress()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject go = GameObject.Instantiate(korGE);
            Transform target = Camera.main.transform;
            go.transform.parent = target;
            n++;
        }
    }

}
