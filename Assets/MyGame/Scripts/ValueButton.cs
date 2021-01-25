using UnityEngine;
using UnityEngine.UI;


public class ValueButton : MonoBehaviour
{
    public float Number;
    public Text Value;

    public void ValueScript()
    {
        Number = UnityEngine.Random.value;
        Value.text = Number.ToString();
        Debug.Log("Ich werde gedrückt.");
    }
}
