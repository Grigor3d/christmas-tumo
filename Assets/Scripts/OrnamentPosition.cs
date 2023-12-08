using UnityEngine;

public class OrnamentPosition : MonoBehaviour
{
    public Ornament.Type type = Ornament.Type.Regular;
    private string _attachedOrnamentName;

    public string AttachedOrnamentName
    {
        get
        {
            return _attachedOrnamentName;
        }
        set
        {
            _attachedOrnamentName = value;
            Ornament ornamentPrefab = Resources.Load<Ornament>("Ornaments/" + _attachedOrnamentName);
            Instantiate(ornamentPrefab, this.transform);
        }
    }
}