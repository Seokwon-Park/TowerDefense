using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    private void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }


}
