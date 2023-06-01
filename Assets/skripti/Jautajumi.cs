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
    private int PareizasAtbildes = 0;
 private bool Taimers = true;
    public float TaimeraStarts;
    public float TaimeraBeigas;
    public GameObject tekstaAttelosana;
    public Toggle[] AtbildesTogglePogas;
    public Button nakošaisJautajumsPoga;
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;
    public GameObject BeiguScreen;
    public GameObject TextaLaiks;
    public GameObject CikNoCik;
    public GameObject Zvaigzne1;
    public GameObject Zvaigzne2;
    public GameObject Zvaigzne3;
    private void Start()
    {
        Taimers = true;
        IzvaditJautajumu();
        SaktTimer();
    }
    private void Update(){
         if (Taimers)
        {
            if (indekss < 10 && !BeiguScreen.activeSelf)
            {
                TaimeraBeigas = Time.time;
            }
            else
            {
                Taimers = false;
                BeigtTimer();
            }
        }
    }

#region VissKasIrPrieksJautajumiem
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
                PareizasAtbildes++;
            }
            
        }if (indekss == 1){
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta2");
            }

        }
         if (indekss == 2){
            if (AtbildesTogglePogas[3].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta3");
            }

        }
         if (indekss == 3){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta4");
            }

        }
         if (indekss == 4){/////////
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta5");
            }

        }
         if (indekss == 5){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta6");
            }

        }
         if (indekss == 6){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta7");
            }

        }
         if (indekss == 7){
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta8");
            }

        }
         if (indekss == 8){
            if (AtbildesTogglePogas[2].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta9");
            }

        }
         if (indekss == 9){
            if (AtbildesTogglePogas[3].isOn)
            {
               PareizasAtbildes++;
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
    #endregion

#region TimeraDaļa
private void SaktTimer()
    {
        TaimeraStarts = Time.time;
        Debug.Log("Timer started!");
    }

    private void BeigtTimer()
    {
        TaimeraBeigas = Time.time;
        float duration = TaimeraBeigas - TaimeraStarts;
        Debug.Log("Laiks Beidzās! Laiks: " + duration.ToString("F2") + " Sekundes");
        TextaLaiks.GetComponent<Text>().text ="Laiks: " +duration.ToString("F2") + " Sekundes";
        CikNoCik.GetComponent<Text>().text=PareizasAtbildes+"/10";
        if(PareizasAtbildes>=9f){
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
                Zvaigzne2.SetActive(!Zvaigzne2.activeSelf);
                Zvaigzne3.SetActive(!Zvaigzne3.activeSelf);
            }else if(PareizasAtbildes>=5f && PareizasAtbildes <=8){
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
                Zvaigzne2.SetActive(!Zvaigzne2.activeSelf);
            }else{
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
            }
    }

#endregion


    #region ZvaigznesDala
        // private void Zvaigznes(){
        //     if(duration.ToString("F2")>=3f){
        //         Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
        //     }
        // }


    #endregion
}
