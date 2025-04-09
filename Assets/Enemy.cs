using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Etiket Listesi (XList)")]
    public XList enemyTags = new XList();

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;

        Debug.Log($"{gameObject.name}  tags: {enemyTags}");

        if (enemyTags.HasTag("explosive"))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (enemyTags.HasTag("boss"))
        {
            transform.localScale = new Vector3(2f, 2f, 1f);
        }
    }

    void Update()
    {
        if (enemyTags.HasTag("flying"))
        {
            float floatSpeed = 2f;
            float floatHeight = 0.5f;

            Vector3 newPos = originalPosition;
            newPos.y += Mathf.Sin(Time.time * floatSpeed) * floatHeight;

            transform.position = newPos;
        }
    }

    public bool HasTag(string tag)
    {
        return enemyTags.HasTag(tag);
    }
}
