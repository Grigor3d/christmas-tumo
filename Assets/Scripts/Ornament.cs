using UnityEngine;

public class Ornament : MonoBehaviour
{

   public enum Type
    {
        Top,
        Regular
    }





[SerializeField] private Renderer bodyRenderer;
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private Sprite screenshot;



    public Type type;
    public Renderer BodyRenderer => bodyRenderer;
    public Rigidbody SphereRigidbody => sphereRigidbody;
    public Sprite Screenshot => screenshot;

}