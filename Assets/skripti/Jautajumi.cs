using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jautajumi : MonoBehaviour {

    private List<string> fragmenti = new List<string> {"kā mani sauc?", "mana suņa krāsa?", "kad man ir dzimšanas diena?", "Par ko es mācos?",
    "cik man ir pirksti?"," kā sauc manu suni?","Kurā skolā es mācos?","kādu telefona ražotāju es izmantoju?","manas māsas vārds?","mana skolotāja vārds"};
    private List<string> fragmenti1 = new List<string> {"Kristians", "Balta", "4", "Pavāru","10","Madars","UML","Samsung","Sigita","kristoferis"};
    private List<string> fragmenti2 = new List<string> {"Alekss", "Melna", "5", "Programmētāju","9","dora","LVT","HUAWEI","kristians","māris"};
    private List<string> fragmenti3 = new List<string> {"Ralfs", "Dzelten", "6", "Frizieri","8","suns","RTU","lGato","Selita","rihards"};
    private List<string> fragmenti4 = new List<string> {"Tomijs", "Zila", "7", "Mehatroniķis","7","džeina","ugunsdzēsējs","iphone","Anna","Kristaps"};

    private int indekss = 0;

    public GameObject tekstaAttelosana;
    public Toggle[] AtbildesTogglePogas;
    public Button nakošaisJautajumsPoga;
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;
    public GameObject BeiguScreen;

    private void Start()
    {
        IzvaditJautajumu();
    }

    public void UzglabatTekstu()
    {
        if (indekss < fragmenti.Count)
        {
            if (!VaiToggleIrIeslegts())
                return;

                if (indekss == 0)
        {
            if (AtbildesTogglePogas[0].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta1");
            }
            
        }if (indekss == 1){
            if (AtbildesTogglePogas[0].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta2");
            }

        }
         if (indekss == 2){
            if (AtbildesTogglePogas[3].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta3");
            }

        }
         if (indekss == 3){
            if (AtbildesTogglePogas[3].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta4");
            }

        }
         if (indekss == 4){/////////
            if (AtbildesTogglePogas[0].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta5");
            }

        }
         if (indekss == 5){
            if (AtbildesTogglePogas[1].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta6");
            }

        }
         if (indekss == 6){
            if (AtbildesTogglePogas[1].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta7");
            }

        }
         if (indekss == 7){
            if (AtbildesTogglePogas[0].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta8");
            }

        }
         if (indekss == 8){
            if (AtbildesTogglePogas[2].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta9");
            }

        }
         if (indekss == 9){
            if (AtbildesTogglePogas[3].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta10");
            }

        }


            indekss++;
        if(indekss==10){
             BeiguScreen.SetActive(!BeiguScreen.activeSelf);
        }
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

    private bool VaiToggleIrIeslegts()
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
