using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAttack : MonoBehaviour {

    public int attackVal = 0;
    public GameObject cam;
    public Button b;
    
    private void OnEnable() {
        gameObject.GetComponent<Text>().text = GetCurrentCharacter().GetSpecificAttack(attackVal);
        b = gameObject.GetComponent<Button>();
        b.onClick.RemoveAllListeners();
        switch (attackVal) {
            case 0:
                b.onClick.AddListener(GetCurrentCharacter().AttackOne);
                break;
            case 1:
                b.onClick.AddListener(GetCurrentCharacter().AttackTwo);
                break;
        }
    }

    GenericClass GetCurrentCharacter() {
        return cam.GetComponent<Follow>().GetTarget().gameObject.GetComponent<GenericClass>();
    }
}
