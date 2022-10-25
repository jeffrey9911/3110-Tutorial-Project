using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrototypeFactory : MonoBehaviour
{
    public List<CollectableData> allData;

    public GameObject _btnPanel;
    public GameObject _btnPrefab;

    private EditorManager _editorManager;

    Coin coinPRTP;
    BlueGem bluegemPRTP;
    GreenGem greengemPRTP;
    PinkGem pinkgemPRTP;

    private void Start()
    {
        _editorManager = EditorManager.Instance;

        coinPRTP = new Coin(allData[0]._prefab, allData[0]._score);
        bluegemPRTP = new BlueGem(allData[1]._prefab, allData[1]._score);
        greengemPRTP = new GreenGem(allData[2]._prefab, allData[2]._score);
        pinkgemPRTP = new PinkGem(allData[3]._prefab, allData[3]._score);

        for(int i = 0; i < allData.Count; i++)
        {
            var button = Instantiate(_btnPrefab);
            button.transform.SetParent(_btnPanel.transform);
            button.gameObject.name = "BTN_" + allData[i].name;
            button.GetComponentInChildren<TextMeshProUGUI>().text = allData[i].name + " Button";
            button.GetComponent<Button>().onClick.AddListener(delegate { Spawner(button); });
        }
    }

    void Spawner(GameObject button)
    {
        var btn = button.GetComponentInChildren<TextMeshProUGUI>();

        Debug.Log(btn.text);

        switch(btn.text)
        {
            case "Coin Button":
                _editorManager.item = coinPRTP.Clone().Spawn();
                break;
            case "Gem_Blue Button":
                _editorManager.item = bluegemPRTP.Clone().Spawn();
                break;
            case "Gem_Green Button":
                _editorManager.item = greengemPRTP.Clone().Spawn();
                break;
            case "Gem_Pink Button":
                _editorManager.item = pinkgemPRTP.Clone().Spawn();
                break;
            default:
                break;
        }

        _editorManager.instantiated = true;
    }
}
