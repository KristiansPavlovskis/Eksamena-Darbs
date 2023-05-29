using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jautajumi : MonoBehaviour {

    private List<string> fragmenti = new List<string> {"kā mani sauc?", "mana suņa krāsa?", "kad man ir dzimšanas diena?", "Par ko es mācos?"};
    private List<string> fragmenti1 = new List<string> {"Kristians", "Balta", "4", "Pavāru"};
    private List<string> fragmenti2 = new List<string> {"Alekss", "Melna", "5", "Programmētāju"};
    private List<string> fragmenti3 = new List<string> {"Ralfs", "Dzelten", "6", "Frizieri"};
    private List<string> fragmenti4 = new List<string> {"Tomijs", "Zila", "7", "Mehatroniķis"};

    private int indekss = 0;

    public GameObject tekstaAttelosana;
    public Toggle[] AtbildesTogglePogas;
    public Button nakošaisJautajumsPoga;
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;

    private void Start()
    {
        IzvaditJautajumu();
    }

    public void UzglabatTekstu()
    {
        if (indekss < fragmenti.Count)
        {
            if (!IsAnyToggleSelected())
                return;

            indekss++;
            IzvaditJautajumu();
        }
    }

    private void IzvaditJautajumu()
    {
        if (indekss < fragmenti.Count)
        {
            tekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss];
            IzvaditAtbildes();
            IzslegtTogglePogu();
        }
    }

    private void IzvaditAtbildes()
    {
        if (indekss < fragmenti.Count)
        {
            toggle1.GetComponent<Text>().text = fragmenti1[indekss];
            toggle2.GetComponent<Text>().text = fragmenti2[indekss];
            toggle3.GetComponent<Text>().text = fragmenti3[indekss];
            toggle4.GetComponent<Text>().text = fragmenti4[indekss];
        }
    }

    private void IzslegtTogglePogu()
    {
        for (int i = 0; i < AtbildesTogglePogas.Length; i++)
        {
            AtbildesTogglePogas[i].isOn = false;
        }
    }

    private bool IsAnyToggleSelected()
    {
        for (int i = 0; i < AtbildesTogglePogas.Length; i++)
        {
            if (AtbildesTogglePogas[i].isOn)
            {
                return true;
            }
        }
        return false;
    }
}
