using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class XList
{
    [SerializeField]
    private List<string> tags = new List<string>();

    // Yeni bir etiket ekler
    public void AddTag(string tag)
    {
        if (!tags.Contains(tag))
        {
            tags.Add(tag);
        }
    }

    // Etiketi kaldırır
    public void RemoveTag(string tag)
    {
        if (tags.Contains(tag))
        {
            tags.Remove(tag);
        }
    }

    // Etiketin olup olmadığını kontrol eder
    public bool HasTag(string tag)
    {
        return tags.Contains(tag);
    }

    // Tüm etiketleri listeler
    public List<string> GetTags()
    {
        return new List<string>(tags);
    }

    // Tüm etiketleri string olarak döndür
    public override string ToString()
    {
        return string.Join(", ", tags);
    }
}

