using UnityEngine;

public class Efficient_Test : MonoBehaviour
{
    private string _a;
    private string _b;
    private GameObject _obj;

    void Start()
    {
        _obj = gameObject;
        Efficienct_Comparison.Efficiency.Compare(GoGoA, GoGoB, 100000);
    }

    public void GoGoA() {
        _a = gameObject.name;
    }

    public void GoGoB() {
        _b = _obj.name;
    }
}
