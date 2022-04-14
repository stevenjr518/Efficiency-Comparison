using UnityEngine;

public class Efficient_Test : MonoBehaviour
{
    private string A;
    private string B;
    private GameObject obj;

    void Start()
    {
        obj = gameObject;
        Efficienct_Comparison.Efficiency.Compare(GoGoA, GoGoB, 100000);
    }

    public void GoGoA() {
        A = gameObject.name;
    }

    public void GoGoB() {
        B = obj.name;
    }
}
